import json
import os
from fastapi import FastAPI, HTTPException
from pydantic import BaseModel

app = FastAPI()

FICHERO_PRODUCTOS = "productos.json"
FICHERO_VENTAS = "ventas.json"

# --- MODELOS DE DATOS ---
class Producto(BaseModel):
    id: int
    nombre: str
    categoria: str
    precioKg: float
    stockKg: float

class Venta(BaseModel):
    id_producto: int
    cantidad: float

# --- FUNCIONES DE PERSISTENCIA JSON ---
def cargar_datos():
    if os.path.exists(FICHERO_PRODUCTOS):
        with open(FICHERO_PRODUCTOS, "r", encoding="utf-8") as f:
            prods = [Producto(**item) for item in json.load(f)]
    else:
        prods = [
            Producto(id=1, nombre="Manzana Golden", categoria="Fruta", precioKg=2.10, stockKg=25.0),
            Producto(id=2, nombre="Plátano de Canarias", categoria="Fruta", precioKg=2.65, stockKg=4.0),
            Producto(id=3, nombre="Tomate Pera", categoria="Verdura", precioKg=1.80, stockKg=15.0)
        ]
        guardar_productos(prods)

    if os.path.exists(FICHERO_VENTAS):
        with open(FICHERO_VENTAS, "r", encoding="utf-8") as f:
            vents = [Venta(**item) for item in json.load(f)]
    else:
        vents = []
        guardar_ventas(vents)

    return prods, vents

def guardar_productos(lista_productos):
    with open(FICHERO_PRODUCTOS, "w", encoding="utf-8") as f:
        json.dump([p.model_dump() for p in lista_productos], f, indent=4, ensure_ascii=False)

def guardar_ventas(lista_ventas):
    with open(FICHERO_VENTAS, "w", encoding="utf-8") as f:
        json.dump([v.model_dump() for v in lista_ventas], f, indent=4, ensure_ascii=False)

productos, ventas = cargar_datos()

# --- ENDPOINTS DE PRODUCTOS ---

@app.get("/productos")
def listar_productos():
    return productos

@app.post("/productos")
def crear_producto(producto: Producto):
    productos.append(producto)
    guardar_productos(productos)
    return producto

@app.put("/productos/{id}")
def actualizar_producto(id: int, producto_actualizado: Producto):
    for i, p in enumerate(productos):
        if p.id == id:
            productos[i] = producto_actualizado
            guardar_productos(productos)
            return producto_actualizado
    raise HTTPException(status_code=404, detail="Producto no encontrado")

@app.delete("/productos/{id}")
def borrar_producto(id: int):
    global productos
    productos[:] = [p for p in productos if p.id != id]
    guardar_productos(productos)
    return {"ok": True}

# --- ENDPOINTS DE VENTAS ---

@app.post("/ventas")
def registrar_venta(venta: Venta):
    for p in productos:
        if p.id == venta.id_producto:
            if p.stockKg >= venta.cantidad:
                p.stockKg -= venta.cantidad
                ventas.append(venta)
                guardar_productos(productos)
                guardar_ventas(ventas)
                return {"mensaje": "Venta correcta", "producto": p.nombre, "stock_restante": p.stockKg}
            else:
                raise HTTPException(status_code=400, detail="Stock insuficiente")

    raise HTTPException(status_code=404, detail="Producto no encontrado")

@app.get("/ventas")
def listar_ventas():
    return ventas

# --- ENDPOINT DE INFORMES (OPCIONAL) ---

@app.get("/informes/ventas-hoy")
def informe_ventas_hoy():
    total_euros = 0.0
    kilos_por_producto = {}

    for v in ventas:
        prod = next((p for p in productos if p.id == v.id_producto), None)
        if prod:
            total_euros += prod.precioKg * v.cantidad
            kilos_por_producto[prod.nombre] = kilos_por_producto.get(prod.nombre, 0.0) + v.cantidad

    if kilos_por_producto:
        nombre_top = max(kilos_por_producto, key=kilos_por_producto.get)
        producto_mas_vendido = f"{nombre_top} ({kilos_por_producto[nombre_top]:.2f} Kg)"
    else:
        producto_mas_vendido = "Sin ventas registradas"

    return {
        "total_vendido": round(total_euros, 2),
        "numero_ventas": len(ventas),
        "producto_mas_vendido": producto_mas_vendido
    }
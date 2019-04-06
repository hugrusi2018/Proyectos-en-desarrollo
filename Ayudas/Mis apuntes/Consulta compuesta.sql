SELECT * 
FROM detalle_movimiento_product det, movimiento_productos move
where det.Nro_Documento='529' and  move.idMvto=det.idMvto
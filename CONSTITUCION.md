# Constitución técnica de GlucoApp

Este documento define los principios técnicos permanentes de GlucoApp. Ante una decisión de implementación, estos principios prevalecen sobre convenciones locales y preferencias personales.

## Stack base

1. ASP.NET Core MVC (.NET 9), EF Core, SQL Server, Identity y Bootstrap 5 son el stack base del proyecto.
2. No se agregan dependencias ni frameworks sin una justificación explícita y aprobación previa.

## Arquitectura y código

3. Todo nombre de dominio y código nuevo se escribe en español.
4. Los controladores son delgados; la lógica de negocio reside exclusivamente en servicios.
5. Las vistas no contienen lógica de negocio ni acceso directo a datos.
6. No se eliminan columnas, funciones ni nombres públicos sin autorización explícita.

## Datos y rendimiento

7. Cada cambio de modelo evalúa las migraciones necesarias, las relaciones y la integridad referencial.
8. Las consultas deben ser eficientes: usar `AsNoTracking`, proyecciones e `Include` solo cuando aporten valor.

## Seguridad y validación

9. Toda entrada se valida con `ModelState` y las acciones mutables usan protección antiforgery.
10. No se exponen secretos, errores internos ni excepciones al usuario.

## Experiencia de usuario

11. Todo cambio mantiene un diseño responsive y coherente con Bootstrap 5.

## Calidad y verificación

12. Cada funcionalidad nueva incluye pruebas proporcionales de servicio o controlador.
13. Antes de integrar, el proyecto compila sin errores, sin advertencias nuevas y pasan sus pruebas.

## Flujo de aprobación

14. Antes de modificar, se analiza el impacto, se explica la propuesta y se espera aprobación explícita del usuario.

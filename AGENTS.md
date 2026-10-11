# GlucoApp

## Propósito y alcance

GlucoApp permite registrar, consultar y organizar mediciones de glucosa de cada usuario.

- No brinda diagnósticos, tratamientos ni recomendaciones médicas.
- Los datos de glucosa son información personal sensible y solo deben estar disponibles para su propietario, salvo roles administrativos definidos explícitamente.
- La aplicación conserva la arquitectura MVC y sus carpetas principales: `Controllers`, `Models`, `Views`, `Services`, `Data`, `Migrations` y `wwwroot`.

## Jerarquía de instrucciones

1. Instrucciones de plataforma y del usuario.
2. Documentación técnica y decisiones de arquitectura existentes en el repositorio.
3. Este archivo, para las reglas generales de operación.
4. El perfil especializado aplicable en `.agents/`.

Ante una contradicción, se aplica la instrucción de mayor prioridad. Los perfiles especializados complementan este archivo y no reemplazan la documentación técnica del proyecto.

## Flujo de trabajo

Antes de modificar archivos:

1. Analizar el código y el impacto en arquitectura, datos, seguridad, rendimiento y experiencia de usuario.
2. Explicar la propuesta e identificar archivos, capas, clases y cambios de base de datos que correspondan.
3. Esperar la aprobación explícita del usuario.
4. Implementar únicamente después de recibirla.
5. Ejecutar verificaciones pertinentes y reportar el resultado, incluidas las que no pudieron realizarse y su motivo.

## Reglas generales de operación

- Completar la funcionalidad solicitada en todas las capas estrictamente necesarias para cerrarla correctamente.
- No añadir funcionalidades, rediseños ni refactorizaciones no solicitadas. Documentar las mejoras detectadas y esperar aprobación antes de realizarlas.
- Preservar cambios preexistentes y no sobrescribir trabajo ajeno.
- Validar la propiedad de cada registro antes de permitir su consulta, edición o eliminación.
- No registrar en logs valores de glucosa, notas personales, contraseñas, tokens, cadenas de conexión ni otros datos sensibles.
- Mantener explícitas la unidad de medida, la fecha y la hora de cada medición; no asumir ni convertir unidades de forma silenciosa.
- Informar bloqueos, riesgos, supuestos relevantes y limitaciones de verificación.
- Consultar [CONSTITUCION.md](CONSTITUCION.md) para los principios de stack, arquitectura, seguridad, calidad y límites del proyecto.

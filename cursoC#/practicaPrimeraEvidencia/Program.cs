// PLANTEAMIENTO DEL PROBLEMA: 
// SISTEMA DE REGISTRO DE CALIFICACIONES DE ESTUDIANTES
// UN DOCENTE NECESITA UN PROGRAMA QUE LE PERMITA REGISTRAR LAS CALIFICACIONES DE SUS
// ESTUDIANTES PARA LUEGO PODER CALCULAR EL PROMEDIO DE CADA UNO Y DETERMINAR SI APROBARON O REPROBARON LA ASIGNATURA.
// REQUISITOS:
// [1] SOLICITAR LA CANTIDAD DE ESTUDIANTES A EVALUAR
// [2] POR CADA ESTUDIANTE, PEDIR 3 CALIFICACIONES CON VALORES VALIDOS DE 0.0 HASTA 5.0
// [3] UTILIZAR CICLOS PARA VALIDAR QUE CADA ENTRADA SEA UN NÚMERO VÁLIDO Y ESTÉ EN EL RANGO PERMITIDO (REPETIR LA SOLICITUD HASTA QUE EL VALOR INGRESADO SEA CORRECTO).
// [4] CALCULAR EL PROMEDIO INDIVIDUAL DE CADA ESTUDIANTE Y DETERMINAR MEDIANTE UN IF SI APROBÓ (NOTA >= 3.0) O REPROBRÓ (NOTA < 3.0).
// [5] AL FINALIZAR EL REGISTRO DE TODOS LOS ESTUDIANTES, MOSTRAR: PROMEDIO TOTAL DEL GRUPO, TOTAL DE ESTUDIANTES APROBADOS Y TOTAL DE ESTUDIANTES REPROBADOS.

using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================
        // DECLARACION DE VARIABLES
        // ==========================
        int cantidadEstudiantes = 0;
        int totalAprobados = 0;
        int totalReprobados = 0;
        double sumaPromediosGrupo = 0;

        Console.WriteLine("=== SISTEMA DE REGISTRO DE CALIFICACIONES DE ESTUDIANTES ===");

        // ==========================
        // VALIDACION CANTIDAD DE ESTUDIANTES
        // ==========================
        while(cantidadEstudiantes <= 0)
        {
            Console.Write("INGRESE LA CANTIDAD DE ESTUDIANTES: ");
            string entrada = Console.ReadLine();

            if(int.TryParse(entrada, out cantidadEstudiantes) && cantidadEstudiantes > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("ERROR: DEBE INGRESAR UN NÚMERO ENTERO POSITIVO.");
            }
        }

        for (int i=1; i <= cantidadEstudiantes; i++)
        {
            Console.WriteLine($"ESTUDIANTE {i}");
            double sumaNotasEstudiante = 0;
            
            for(int j = 1; j <= 3; j++)
            {
                double nota = -1;
            }
        }

    }
}

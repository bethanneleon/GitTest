using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            //funcionalidades CRUD con entity framework
            using (HogwartsBDEntities db = new HogwartsBDEntities())
            {
                #region Consulta

                //var lst = db.Inscripcion;

                //foreach (Inscripcion item in lst)
                //{
                //    Console.WriteLine(item.Nombre + " " + item.Apellido);
                //}

                #endregion

                #region Agregar

                //Inscripcion oInscripcion = new Inscripcion();
                //oInscripcion.Apellido = "Marmol";
                //oInscripcion.Nombre = "Pablo";
                //oInscripcion.Edad =18;
                //oInscripcion.Identificacion = 13467989;
                //oInscripcion.IdCasa = 2;

                //db.Inscripcion.Add(oInscripcion);
                //db.SaveChanges();


                #endregion

                #region Editar

                //busca el registro a editar
                //Inscripcion oInscripcion = db.Inscripcion.Where(d => d.Nombre == "Pablo").First();

                //oInscripcion.IdCasa = 4;
                //oInscripcion.Apellido = "Porcelanato";

                //db.Entry(oInscripcion).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();

                #endregion

                #region Eliminar

                
                Inscripcion oInscripcion = db.Inscripcion.Find(2);
                db.Inscripcion.Remove(oInscripcion);
                db.SaveChanges();
             

                #endregion
            }

            Console.ReadLine();
        }
    }
}

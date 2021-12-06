using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangalist.Classes
{
    //
    // Classe listar passa informações para DataGridView
    //
    class Listar
    {
        public int Id { get; set; }
        public string Título { get; set; }
        public string Pontuação { get; set; }
        public int Capítulos { get; set; }
        public string Status { get; set; }
    }
}

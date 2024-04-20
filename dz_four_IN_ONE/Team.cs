using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_four_IN_ONE
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sity { get; set; }
        public int LoseCount { get; set; }
        public int WinCount { get; set; }
        public int DrawCount { get; set; }
        public int GoalsWin { get; set; }
        public int GoalsLose { get; set; }
    }
}

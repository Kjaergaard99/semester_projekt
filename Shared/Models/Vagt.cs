using System;
namespace semester_projekt.Shared.Models
{
    public class Vagt
    {
        public int VagtId { get; set; }
        public DateTime Dato { get; set; }
        public DateTime VagtStart { get; set; }
        public DateTime VagtSlut { get; set; }
        public int Pause { get; set; }
        public string Område { get; set; }
        public int OpgaveId { get; set; }
        public bool ErBooket { get; set; }
        public int BrugerId { get; set; }

        public Vagt()
        {
        }
    }
}


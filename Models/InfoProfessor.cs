namespace SysgestColegios.Models
{
    public class InfoProfessor
    {
        public int Id_Professor { get; set; }
        public string Professor { get; set; }
        public string Turma { get; set; }
        public int IdTurma { get; set; }
        public int QtdAlunos { get; set; }
        public int NumVagas { get; set; }
    }
}

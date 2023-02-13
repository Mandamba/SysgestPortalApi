namespace SysgestColegios.Models
{
    public class ObjInfoAluno
    {
        public int Numero { get; set; }
        public string? Nome { get; set; }
        public string? Genero { get; set; }
        public string? Classe { get; set; }
        public string? Turma { get; set; }
        public string? Estado { get; set; }
        public string? ApiId { get; set; }
        public int IdClasse { get; set; }
        public int Id_Turma { get; set; }
        public byte[]? FotoByte { get; set; }
        public int NumOrdem { get; set; } 
    }
}

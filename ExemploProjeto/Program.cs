using ExemploProjeto.Models;

Pessoa p1 = new Pessoa( nome:"Hellio", sobrenome:"Bonfim");
Pessoa p2 = new Pessoa(nome:"Jaquelson", sobrenome:"Bonfim");


Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Ingles";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionarAluno(p1);

CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAlunos();
p1.Apresentar();
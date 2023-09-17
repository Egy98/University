using University.Controllers;

internal class Program
{
    private static void Main(string[] args)
    {
        StudenteController studController = new StudenteController();
        studController.stampaElencoStudente();
        CorsoController corsController = new CorsoController();
        corsController.stampaElencoCorso();
        Studente_corsoController stud_corsController = new Studente_corsoController();
        stud_corsController.stampaElencoStud_corso();

    }
}
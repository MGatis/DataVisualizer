namespace DataVisualizer.Core.Entities;

public class Vacancy
{
    public int Id { get; set; }
    public string VacancyNumber { get; set; } = "";          // Vakances_Nr
    public DateOnly UpdatedOn { get; set; }                   // Aktualizacijas_datums
    public string EmployerRegistrationNumber { get; set; } = ""; // Iestades_registracijas_numurs
    public string Title { get; set; } = "";                   // Vakances_nosaukums
    public string? Category { get; set; }                     // Vakances_kategorija
    public decimal? SalaryFrom { get; set; }                  // Alga_no
    public decimal? SalaryTo { get; set; }                    // Alga_lidz
    public string? WorkloadType { get; set; }                 // Slodzes_tips
    public string? WorkTimeType { get; set; }                 // Darba_laika_veids
    public decimal? HoursPerWeek { get; set; }                // Darba_stundas_nedela
    public DateOnly? ApplicationDeadline { get; set; }        // Pieteiksanas_termins
    public string? ImageUrl { get; set; }                     // Attels
    public string? Location { get; set; }                     // Vieta
    public string? DetailsUrl { get; set; }                   // Vakances_paplasinats_apraksts

    public DateTime FirstImportedAt { get; set; }
    public DateTime LastImportedAt { get; set; }
}
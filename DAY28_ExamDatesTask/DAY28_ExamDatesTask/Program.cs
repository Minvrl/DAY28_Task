Dictionary<string, DateTime> exams = new Dictionary<string, DateTime>();
exams.Add("Math", new DateTime(2024,06,07));
exams.Add("English", new DateTime(2025 , 08, 07));
exams.Add("Computer Architechture", new DateTime(2024 , 06, 09));
exams.Add("Biology", new DateTime(2024 , 03, 04));
exams.Add("History", new DateTime(2024, 02,  07));

int i = 1;
Console.WriteLine("====  EXAMS  ====");
foreach (var exam in exams)
{
    int daysLeft = (exam.Value.Date - DateTime.Now.Date).Days;
    Console.WriteLine($"{i}. Exam - {exam.Key}, Date - {exam.Value.Date.ToString("dd.MM.yyyy")} , Days left till exam - {daysLeft}");
    i++;
}




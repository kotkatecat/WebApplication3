using WebApplication3;

internal static class ProgramHelpers
{
    public static void Main()
    {
        List<Folder> folders = new List<Folder>();

        Folder folder1 = new Folder("Folder 1");
        Note note1 = new() { Title = "Note 1", Content = "Content of Note 1" };
        Note note2 = new Note { Title = "Note 2", Content = "Content of Note 2" };
        folder1.Notes.Add(note1);
        folder1.Notes.Add(note2);

        Folder folder2 = new Folder("Folder 2");
        Note note3 = new Note { Title = "Note 3", Content = "Content of Note 3" };
        folder2.Notes.Add(note3);

        folders.Add(folder1);
        folders.Add(folder2);

        // Для примера, выводим все заметки в папках
        foreach (var folder in folders)
        {
            Console.WriteLine($"Folder: {folder.Name}");
            foreach (var note in folder.Notes)
            {
                Console.WriteLine($"Note: {note.Title} - {note.Content}");
            }
            Console.WriteLine();
        }
    }
}
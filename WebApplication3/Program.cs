namespace WebApplication3
{
    public class Note
    {
        public required string Title { get; set; }
        public string? Content { get; set; }

        public record Folder(string Name, List<Note> Notes)
        {
            public Folder(string name) : this(name, new List<Note>())
            {
            }
        }

        public class Program
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
            public static void Main()
            {
                Notebook notebook = new Notebook();


                notebook.AddNote(new Note("Note 1", "Content 1", true, "Folder 1"));
                notebook.AddNote(new Note("Note 2", "Content 2", false, "Folder 2"));
                notebook.AddNote(new Note("Note 3", "Content 3", true, "Folder 1"));


                Console.WriteLine("All Notes:");
                notebook.ShowAllNotes();


                Console.WriteLine("Notes in Folder 1:");
                notebook.ShowNotesInFolder("Folder 1");
            }
        }


        public static string noteTitle = "Note Title";
        public static string noteContent = "Note Content";
        public static bool isNoteImportant = false;
        public static string noteFolder = "Folder 1";

        public static void UpdateNoteTitle(string newTitle)
        {
            noteTitle = newTitle;
        }

        public static void UpdateNoteContent(string newContent)
        {
            noteContent = newContent;
        }

        public static void UpdateNoteImportance(bool isImportant)
        {
            isNoteImportant = isImportant;
        }

        public static void UpdateNoteFolder(string newFolder)
        {
            noteFolder = newFolder;
        }

        public static void Main()
        {

            Console.WriteLine($"Title: {noteTitle}");
            Console.WriteLine($"Content: {noteContent}");
            Console.WriteLine($"Is Important: {isNoteImportant}");
            Console.WriteLine($"Folder: {noteFolder}");


            UpdateNoteTitle("Updated Title");
            UpdateNoteContent("Updated Content");
            UpdateNoteImportance(true);
            UpdateNoteFolder("Folder 2");


            Console.WriteLine($"Updated Title: {noteTitle}");
            Console.WriteLine($"Updated Content: {noteContent}");
            Console.WriteLine($"Is Important: {isNoteImportant}");
            Console.WriteLine($"Folder: {noteFolder}");
        }
    }
    public class Notebook
    {
        private List<Note> notes = new List<Note>();

        public void AddNote(Note note)
        {
            notes.Add(note);
        }

        public void ShowAllNotes()
        {
            foreach (var note in notes)
            {
                Console.WriteLine($"Title: {note.Title}");
                Console.WriteLine($"Content: {note.Content}");
                Console.WriteLine($"Is Important: {note.IsImportant}");
                Console.WriteLine($"Folder: {note.Folder}");
                Console.WriteLine();
            }
        }

        public void ShowNotesInFolder(string folderName)
        {
            foreach (var note in notes)
            {
                if (note.Folder == folderName)
                {
                    Console.WriteLine($"Title: {note.Title}");
                    Console.WriteLine($"Content: {note.Content}");
                    Console.WriteLine($"Is Important: {note.IsImportant}");
                    Console.WriteLine($"Folder: {note.Folder}");
                    Console.WriteLine();
                }
            }
        }
    }

    public class Notebook
    {
        private List<Note> notes = new List<Note>();

        public void AddNote(Note note)
        {
            notes.Add(note);
        }

        public void ShowAllNotes()
        {
            foreach (var note in notes)
            {
                Console.WriteLine($"Title: {note.Title}");
                Console.WriteLine($"Content: {note.Content}");
                Console.WriteLine($"Is Important: {note.IsImportant}");
                Console.WriteLine($"Folder: {note.Folder}");
                Console.WriteLine();
            }
        }

        public void ShowNotesInFolder(string folderName)
        {
            foreach (var note in notes)
            {
                if (note.Folder == folderName)
                {
                    Console.WriteLine($"Title: {note.Title}");
                    Console.WriteLine($"Content: {note.Content}");
                    Console.WriteLine($"Is Important: {note.IsImportant}");
                    Console.WriteLine($"Folder: {note.Folder}");
                    Console.WriteLine();
                }
            }
        }
    }
}
internal static class NoteHelpers
{

    public static void Main()
    {
        // Выводим информацию о заметке до изменений
        Console.WriteLine($"Title: {noteTitle}");
        Console.WriteLine($"Content: {noteContent}");
        Console.WriteLine($"Is Important: {isNoteImportant}");
        Console.WriteLine($"Folder: {noteFolder}");

        // Изменяем заголовок, контент, важность и папку заметки
        UpdateNoteTitle("Updated Title");
        UpdateNoteContent("Updated Content");
        UpdateNoteImportance(true);
        UpdateNoteFolder("Folder 2");

        // Выводим информацию о заметке после изменений
        Console.WriteLine($"Updated Title: {noteTitle}");
        Console.WriteLine($"Updated Content: {noteContent}");
        Console.WriteLine($"Is Important: {isNoteImportant}");
        Console.WriteLine($"Folder: {noteFolder}");
    }
}
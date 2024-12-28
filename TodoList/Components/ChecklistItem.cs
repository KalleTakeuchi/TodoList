namespace TodoList.Components
{
    public class ChecklistItem
    {
        public bool IsChecked { get; set; } = false;
        public string Text { get; set; } = string.Empty;
        public string Assignee { get; set; } = string.Empty;

        public ChecklistItem(string assignee)
        {
            Assignee = assignee;
        }
    }
}

namespace INQ.Logger.Application
{
    public abstract class TextProvider
    {
        protected List<string> _paragraphs = new List<string>();
        protected int _paragraphCounter = 0;
        public string Provide(out bool isDone)
        {
            if (_paragraphs.Count > _paragraphCounter + 1)
            {
                isDone = false;
                _paragraphCounter++;
                return _paragraphs[_paragraphCounter];
            }
            else
            {
                isDone = true;
                _paragraphCounter = 0;
                return "";
            }
        }
    }
}

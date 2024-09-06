namespace SingleResponsibilityPrinciple.Reports {
    public class Report {
        private string _content = "";

        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content) {
            _content = content;
        }

        public void GenerateReport(string content) {
            _content = content;
        }
    }
}
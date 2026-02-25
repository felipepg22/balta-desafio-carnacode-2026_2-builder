namespace DesignPatternChallenge.Models;

public class SalesReport
    {
        public string Title { get; set; }
        public string Format { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IncludeHeader { get; set; }
        public bool IncludeFooter { get; set; }
        public string HeaderText { get; set; }
        public string FooterText { get; set; }
        public bool IncludeCharts { get; set; }
        public string ChartType { get; set; }
        public bool IncludeSummary { get; set; }
        public List<string> Columns { get; set; }
        public List<string> Filters { get; set; }
        public string SortBy { get; set; }
        public string GroupBy { get; set; }
        public bool IncludeTotals { get; set; }
        public string Orientation { get; set; }
        public string PageSize { get; set; }
        public bool IncludePageNumbers { get; set; }
        public string CompanyLogo { get; set; }
        public string WaterMark { get; set; }

        // Problema: Construtor telescópico (muitos parâmetros)
        public SalesReport(
            string title,
            string format,
            DateTime startDate,
            DateTime endDate,
            bool includeHeader,
            bool includeFooter,
            string headerText,
            string footerText,
            bool includeCharts,
            string chartType,
            bool includeSummary,
            List<string> columns,
            List<string> filters,
            string sortBy,
            string groupBy,
            bool includeTotals,
            string orientation,
            string pageSize,
            bool includePageNumbers,
            string companyLogo,
            string waterMark)
        {
            Title = title;
            Format = format;
            StartDate = startDate;
            EndDate = endDate;
            IncludeHeader = includeHeader;
            IncludeFooter = includeFooter;
            HeaderText = headerText;
            FooterText = footerText;
            IncludeCharts = includeCharts;
            ChartType = chartType;
            IncludeSummary = includeSummary;
            Columns = columns;
            Filters = filters;
            SortBy = sortBy;
            GroupBy = groupBy;
            IncludeTotals = includeTotals;
            Orientation = orientation;
            PageSize = pageSize;
            IncludePageNumbers = includePageNumbers;
            CompanyLogo = companyLogo;
            WaterMark = waterMark;
        }

        // Alternativa problemática: Construtor vazio + setters
        public SalesReport()
        {
            Columns = new List<string>();
            Filters = new List<string>();
        }

        public void Generate()
        {
            Console.WriteLine($"\n=== Gerando Relatório: {Title} ===");
            Console.WriteLine($"Formato: {Format}");
            Console.WriteLine($"Período: {StartDate:dd/MM/yyyy} a {EndDate:dd/MM/yyyy}");

            if (IncludeHeader)
                Console.WriteLine($"Cabeçalho: {HeaderText}");

            if (IncludeCharts)
                Console.WriteLine($"Gráfico: {ChartType}");

            Console.WriteLine($"Colunas: {string.Join(", ", Columns)}");

            if (Filters.Count > 0)
                Console.WriteLine($"Filtros: {string.Join(", ", Filters)}");

            if (!string.IsNullOrEmpty(GroupBy))
                Console.WriteLine($"Agrupado por: {GroupBy}");

            if (IncludeFooter)
                Console.WriteLine($"Rodapé: {FooterText}");

            Console.WriteLine("Relatório gerado com sucesso!");
        }
    }
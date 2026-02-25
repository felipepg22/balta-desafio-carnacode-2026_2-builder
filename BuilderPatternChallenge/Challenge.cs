// DESAFIO: Gerador de Relatórios Complexos
// PROBLEMA: Sistema precisa gerar diferentes tipos de relatórios (PDF, Excel, HTML)
// com múltiplas configurações opcionais (cabeçalho, rodapé, gráficos, tabelas, filtros)
// O código atual usa construtores enormes ou muitos setters, tornando difícil criar relatórios

using DesignPatternChallenge.Models;
using DesignPatternChallenge.Builders.SalesReports;

namespace DesignPatternChallenge
{
    // Contexto: Sistema de BI que gera relatórios customizados para diferentes departamentos
    // Cada relatório pode ter dezenas de configurações opcionais
    
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Relatórios ===");

            // Solução 1: Builder Pattern - Fluent interface, mais legível e flexível
            var builder1 = new PdfReportBuilder();
            builder1.SetTitle("Vendas Mensais");
            builder1.SetFormat();
            builder1.SetStartDate(new DateTime(2024, 1, 1));
            builder1.SetEndDate(new DateTime(2024, 1, 31));
            builder1.HasHeader();
            builder1.SetHeaderText("Relatório de Vendas");
            builder1.HasFooter();
            builder1.SetFooterText("Confidencial");
            builder1.HasCharts();
            builder1.SetChartType("Bar");
            builder1.HasSummary();
            builder1.SetColumns(new List<string> { "Produto", "Quantidade", "Valor" });
            builder1.SetFilters(new List<string> { "Status=Ativo" });
            builder1.SetSortBy("Valor");
            builder1.SetGroupBy("Categoria");
            builder1.HasTotals();
            builder1.SetOrientation("Portrait");
            builder1.SetPageSize("A4");
            builder1.HasPageNumbers();
            builder1.SetCompanyLogo("logo.png");
            builder1.SetWaterMark("Confidencial");
            
            var report1 = builder1.Build();
            report1.Generate();

            // Solução 2: Builder Pattern - Ordem clara, todas as configurações em um lugar
            var builder2 = new ExcelReportBuilder();
            builder2.SetTitle("Relatório Trimestral");
            builder2.SetFormat();
            builder2.SetStartDate(new DateTime(2024, 1, 1));
            builder2.SetEndDate(new DateTime(2024, 3, 31));
            builder2.SetColumns(new List<string> { "Vendedor", "Região", "Total" });
            builder2.HasCharts();
            builder2.SetChartType("Line");
            builder2.HasHeader();
            builder2.SetGroupBy("Região");
            builder2.HasTotals();
            
            var report2 = builder2.Build();
            report2.Generate();

            // Solução 3: Builder Pattern - Reutilizando padrões comuns entre relatórios
            var builder3 = new HtmlReportBuilder();
            builder3.SetTitle("Vendas Anuais");
            builder3.SetFormat();
            builder3.SetStartDate(new DateTime(2024, 1, 1));
            builder3.SetEndDate(new DateTime(2024, 12, 31));
            builder3.HasHeader();
            builder3.SetHeaderText("Relatório de Vendas");
            builder3.HasFooter();
            builder3.SetFooterText("Confidencial");
            builder3.SetColumns(new List<string> { "Produto", "Quantidade", "Valor" });
            builder3.HasCharts();
            builder3.SetChartType("Pie");
            builder3.HasTotals();
            builder3.SetOrientation("Landscape");
            builder3.SetPageSize("A4");

            var report3 = builder3.Build();
            report3.Generate();

            // Perguntas para reflexão:
            // - Como criar relatórios complexos sem construtores gigantes?
            // - Como garantir que configurações obrigatórias sejam definidas?
            // - Como reutilizar configurações comuns entre relatórios?
            // - Como tornar o processo de criação mais legível e fluente?
        }
    }
}

using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Builders.SalesReports;

public interface ISalesReportBuilder
{
    public void SetTitle(string title);
    public void SetFormat();
    public void SetStartDate(DateTime startDate);
    public void SetEndDate(DateTime endDate);
    public void HasHeader();
    public void HasFooter();
    public void SetHeaderText(string headerText);
    public void SetFooterText(string footerText);
    public void HasCharts();
    public void SetChartType(string chartType);
    public void HasSummary();
    public void SetColumns(List<string> columns);
    public void SetFilters(List<string> filters);
    public void SetSortBy(string sortBy);
    public void SetGroupBy(string groupBy);
    public void HasTotals();
    public void SetOrientation(string orientation);
    public void SetPageSize(string pageSize);
    public void HasPageNumbers();
    public void SetCompanyLogo(string companyLogo);
    public void SetWaterMark(string waterMark);
    public SalesReport Build();
}
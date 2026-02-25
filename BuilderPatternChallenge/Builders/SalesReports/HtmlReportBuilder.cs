using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Builders.SalesReports;

public class HtmlReportBuilder : ISalesReportBuilder
{
    private readonly SalesReport _salesReport = new();
    
    public void SetTitle(string title)
    {
        _salesReport.Title = title;
    }

    public void SetFormat()
    {
        _salesReport.Format = "HTML";
    }

    public void SetStartDate(DateTime startDate)
    {
        _salesReport.StartDate = startDate;
    }

    public void SetEndDate(DateTime endDate)
    {
        _salesReport.EndDate = endDate;
    }

    public void HasHeader()
    {
        _salesReport.IncludeHeader = true;
    }

    public void HasFooter()
    {
        _salesReport.IncludeFooter = true;
    }

    public void SetHeaderText(string headerText)
    {
        _salesReport.HeaderText = headerText;
    }

    public void SetFooterText(string footerText)
    {
        _salesReport.FooterText = footerText;
    }

    public void HasCharts()
    {
        _salesReport.IncludeCharts = true;
    }

    public void SetChartType(string chartType)
    {
        _salesReport.ChartType = chartType;
    }

    public void HasSummary()
    {
        _salesReport.IncludeSummary = true;
    }

    public void SetColumns(List<string> columns)
    {
        _salesReport.Columns = columns;
    }

    public void SetFilters(List<string> filters)
    {
        _salesReport.Filters = filters;
    }

    public void SetSortBy(string sortBy)
    {
        _salesReport.SortBy = sortBy;
    }

    public void SetGroupBy(string groupBy)
    {
        _salesReport.GroupBy = groupBy;
    }

    public void HasTotals()
    {
        _salesReport.IncludeTotals = true;
    }

    public void SetOrientation(string orientation)
    {
        _salesReport.Orientation = orientation;
    }

    public void SetPageSize(string pageSize)
    {
        _salesReport.PageSize = pageSize;
    }

    public void HasPageNumbers()
    {
        _salesReport.IncludePageNumbers = true;
    }

    public void SetCompanyLogo(string companyLogo)
    {
        _salesReport.CompanyLogo = companyLogo;
    }

    public void SetWaterMark(string waterMark)
    {
        _salesReport.WaterMark = waterMark;
    }

    public SalesReport Build()
    {
        return _salesReport;
    }
}


using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace iPRINT.Core;

public class NetworkService
{
    private List<Interaction> _humanData = new();
    private List<Interaction> _mouseData = new();

    public int GetHumanCount() => _humanData.Count;
    public int GetMouseCount() => _mouseData.Count;

    public void LoadData(string path, string species)
    {
        try 
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                MissingFieldFound = null,
            };

            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, config);
            
            var records = csv.GetRecords<Interaction>().ToList();

            if (species.ToLower() == "human")
                _humanData = records;
            else
                _mouseData = records;

            Console.WriteLine($"[SUCCESS] loaded {species} data: {records.Count} 条");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] loaded {species} data: {ex.Message}");
        }
    }

    public List<Interaction> SearchNetwork(string gene, string species)
    {
        if (string.IsNullOrWhiteSpace(gene)) return new List<Interaction>();
        var source = species.ToLower() == "human" ? _humanData : _mouseData;
        
        return source.Where(i => 
            i.Gene1.Equals(gene, StringComparison.OrdinalIgnoreCase) || 
            i.Gene2.Equals(gene, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Interaction> SearchNetworkMultiple(List<string> genes, string species)
    {
        if (genes == null || !genes.Any()) return new List<Interaction>();

        var source = species.ToLower() == "human" ? _humanData : _mouseData;
        
        var geneSet = new HashSet<string>(genes, StringComparer.OrdinalIgnoreCase);

        return source.Where(i => 
            geneSet.Contains(i.Gene1) || 
            geneSet.Contains(i.Gene2))
            .ToList();
    }

    public List<Interaction> GetInternalEdges(List<string> geneList, string species)
    {
        if (geneList == null || !geneList.Any()) return new List<Interaction>();
        var source = species.ToLower() == "human" ? _humanData : _mouseData;
        
        var geneSet = new HashSet<string>(geneList, StringComparer.OrdinalIgnoreCase);

        return source.Where(i => 
            geneSet.Contains(i.Gene1) && 
            geneSet.Contains(i.Gene2))
            .ToList();
    }
}
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// SECRET DE PRUEBA - GHAS Secret Scanning (fake)
// Este valor es intencionalmente mal formado para activar detecciones de scanner
const string GITHUB_PAC_TOKEN = "ghp_qA1b2C3d4E5f6G7h8I9j0K1l2M3n4O5p6Q7r8";
const string GCP_SECRET_KEY_ID = "1234567890abcdef1234567890abcdef12345678";

app.MapGet("/", () => new {
    Message = "Hola Mundo!",
    SecretScanProof = new {
        githubToken = GITHUB_PAC_TOKEN,
        gcpKeyId = GCP_SECRET_KEY_ID
    }
});

app.Run();

public partial class Program { }
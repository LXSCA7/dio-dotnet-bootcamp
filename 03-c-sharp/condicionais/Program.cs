using condicionais.Models;

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde) {
    Console.WriteLine("vou pedalar hoje");
} else {
    Console.Write("vou pedalar outro dia.");
}
// See https://aka.ms/new-console-template for more information

using Day7;

string[] rawData = File.ReadAllLines("RawData.txt");

ElfDir root = new ElfDir();
CdCommand cmd = new CdCommand();

int i = 1;
if (rawData[i].StartsWith('$'))
    cmd.Execute(rawData, i, root);

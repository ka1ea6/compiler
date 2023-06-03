$input_dir = "..\to_compile"

$exe_files = @(Get-ChildItem "$input_dir\*.exe")
$disassembled_file = "$input_dir\disasembled_code.txt"


foreach ($file in $exe_files)
{
    dotnet-ildasm $file > $disassembled_file
    echo "Disassembled $file and put results in $disassembled_file"
}



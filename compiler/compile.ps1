# $input = ls ..\to_compile | 
# echo $input
$input_dir = "..\to_compile"
$MSCORE_PATH = "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll"
$ms_files = @(Get-ChildItem "$input_dir\*.ms")
if ($ms_files.Count -gt 0)
{
    dotnet run -- $ms_files -r $MSCORE_PATH
    echo "Compiled files in  $input_dir"
}
else {
    echo "No .ms files found in $input_dir"
}
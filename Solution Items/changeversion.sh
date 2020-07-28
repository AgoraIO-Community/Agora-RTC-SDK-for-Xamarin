LibVersion="Xamarin.Agora.$2/Xamarin.Agora.$1.$2/Properties/AssemblyInfo.cs"
NugetVersion="Nugets/Xamarin.Agora.$1.$2/Xamarin.Agora.$1.$2.nuspec"

#########################

sedappid="sed -i '' -e '/<metadata>/,/<\/metadata>/ s|<version>[0-9a-z.-]\{1,\}</version>|<version>$4</version>|g' $NugetVersion" 
echo "$sedappid"
eval "$sedappid"
sedappid="sed -i '' -e 's|AssemblyVersion(\"[0-9a-z.-]\{1,\}\"|AssemblyVersion(\"$3\"|g' $LibVersion" 
echo "$sedappid"
eval "$sedappid"
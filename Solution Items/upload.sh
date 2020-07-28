uploadnuget="nuget push Xamarin.Agora.$1.$2.$3.nupkg $4 -Source https://api.nuget.org/v3/index.json"
echo "$uploadnuget"
eval "$uploadnuget"
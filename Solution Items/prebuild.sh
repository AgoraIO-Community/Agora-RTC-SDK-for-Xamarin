os="$1"
appversion="$2"
nugetversion="$3"

shift 3
for type in "$@"
do
    oneiteration="./Solution\ Items/changeversion.sh $type $os $appversion $nugetversion"
    echo "$oneiteration"
	eval "$oneiteration"
done
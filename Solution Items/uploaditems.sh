os="$1"
version="$2"
key="$3"

shift 3
for type in "$@"
do
    oneiteration="../Solution\ Items/upload.sh $type $os $version $key"
    echo "$oneiteration"
	eval "$oneiteration"
done
os="$1"

shift 1
for type in "$@"
do
    oneiteration="../Solution\ Items/pack.sh $type $os"
    echo "$oneiteration"
	eval "$oneiteration"
done


namespace Tree {
    class AddPolicyItem : PolicyItem {
        public const string TAG = "ADD";

        public AddPolicyItem(int possibleHeapThrow, int possibleSecondHeapThrow) {
            PossibleHeapThrow = possibleHeapThrow;
        }
    }
}
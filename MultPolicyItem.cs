namespace Tree {
    class MultPolicyItem : PolicyItem {
        public const string TAG = "MULT";

        public MultPolicyItem(int possibleHeapThrow) {
            PossibleHeapThrow = possibleHeapThrow;
        }
    }
}
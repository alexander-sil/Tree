namespace Tree {
    class AddRethrowPolicyItem : PolicyItem {
        public const string TAG = "ADD_DIFF";

        public AddRethrowPolicyItem(int possibleHeapThrow, int possibleSecondHeapThrow) {
            PossibleHeapThrow = possibleHeapThrow;
            PossibleSecondHeapThrow = possibleSecondHeapThrow;
        }
        
        public int PossibleSecondHeapThrow { get; set; }
    }
}
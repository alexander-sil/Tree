namespace Tree {
    class Policy {
        public Policy(PolicyItem[] items) {
            policyItems = items.ToList();
        }
        public List<PolicyItem> policyItems { get; set; } = new List<PolicyItem>();
    }
}
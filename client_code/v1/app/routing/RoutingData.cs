namespace TemplateGenerator
{
    partial class Routing
    {
        private readonly string _assemblyName;
        private string _singleName = "";
        private readonly string _pluralName = "";
        private readonly bool _tenantRequired = false;
        private readonly int _recCount = 0;

        public Routing(string assemblyName, string singleName, string pluralName, bool tenantRequired)
        {
            _assemblyName = assemblyName;
            _singleName = singleName;
            _pluralName = pluralName;
            _tenantRequired = tenantRequired;
            _recCount = 0;
        }
    }
}

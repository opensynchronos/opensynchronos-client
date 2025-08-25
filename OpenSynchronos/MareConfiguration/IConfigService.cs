using OpenSynchronos.MareConfiguration.Configurations;

namespace OpenSynchronos.MareConfiguration;

public interface IConfigService<out T> : IDisposable where T : IMareConfiguration
{
    T Current { get; }
    string ConfigurationName { get; }
    string ConfigurationPath { get; }
    public event EventHandler? ConfigSave;
    void UpdateLastWriteTime();
}

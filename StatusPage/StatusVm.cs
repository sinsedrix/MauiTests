using CommunityToolkit.Mvvm.ComponentModel;

namespace StatusPage;

public partial class StatusVm : ObservableObject
{
    public DateTime CurrentTime => DateTime.Now;
    public NetworkAccess NetworkAccess => _connectivity.NetworkAccess;

    public event EventHandler Callback1s;
    public event EventHandler Callback5s;
    public event EventHandler Callback1m;
    public event EventHandler Callback5m;

    readonly Timer _timer1s;
    readonly Timer _timer5s;
    readonly Timer _timer1m;
    readonly Timer _timer5m;
    readonly IConnectivity _connectivity;

    public StatusVm()
    {
        _connectivity = AppServiceProvider.GetService<IConnectivity>();

        _timer1s = new Timer((s) => Refresh1s(), null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        _timer5s = new Timer((s) => Refresh5s(), null, TimeSpan.Zero, TimeSpan.FromSeconds(5));

        _timer1m = new Timer((s) => Refresh1m(), null, TimeSpan.Zero, TimeSpan.FromMinutes(1));
        _timer5m = new Timer((s) => Refresh5m(), null, TimeSpan.Zero, TimeSpan.FromMinutes(5));
    }

    ~StatusVm()
    {
        _timer1s.Dispose();
        _timer5s.Dispose();
        _timer1m.Dispose();
        _timer5m.Dispose();
    }

    void Refresh1s()
    {
        OnPropertyChanged(nameof(CurrentTime));
        Callback1s?.Invoke(this, EventArgs.Empty);
    }

    void Refresh5s()
    {
        OnPropertyChanged(nameof(NetworkAccess));
        Callback5s?.Invoke(this, EventArgs.Empty);
    }

    void Refresh1m()
    {
        Callback1m?.Invoke(this, EventArgs.Empty);
    }

    void Refresh5m()
    {
        Callback5m?.Invoke(this, EventArgs.Empty);
    }
}


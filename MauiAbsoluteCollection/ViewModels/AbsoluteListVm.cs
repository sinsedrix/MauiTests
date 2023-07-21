using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MauiAbsoluteCollection.ViewModels;

public partial class AbsoluteListVm : ObservableObject
{
    public ObservableCollection<AbsoluteVm> Bunch { get; } = new();

    private static readonly Random random = new();

    public static string RandomString(int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz ";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public AbsoluteListVm() {
        for (int i = 0; i < 20; i++)
        {
            Bunch.Add(new AbsoluteVm
            {
                X = (int)new Random().NextInt64(800),
                Y = (int)new Random().NextInt64(600),
                Label = RandomString(8)
            });
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;
using Movies.Service;
using MvvmHelpers;
using System.Collections.ObjectModel;
using System.Linq;

namespace Movies
{
    public class MainPageViewModel : BaseViewModel
    {
        //private CancellationTokenSource _cts;
        //private string _searchTerm;
        //private ObservableCollection<MovieResult> _movies;
        //private bool _noResults = true;

        //public ObservableCollection<MovieResult> Movies
        //{
        //    get => _movies;
        //    private set => SetProperty(ref _movies, value);
        //}

        //public string SearchTerm
        //{
        //    get => _searchTerm;
        //    set
        //    {
        //        if (SetProperty(ref _searchTerm, value))
        //        {
        //            SearchStringChangedAsync(_searchTerm).ContinueWith(tsk => throw new Exception("Search Failed", tsk.Exception), TaskContinuationOptions.OnlyOnFaulted);
        //        }
        //    }
        //}

        //public bool NoResults
        //{
        //    get => _noResults;
        //    set => SetProperty(ref _noResults, value);
        //}

        //private async Task SearchStringChangedAsync(string searchTerm)
        //{
        //    try
        //    {
        //        IsBusy = true;

        //        _cts?.Cancel();
        //        if (!string.IsNullOrWhiteSpace(searchTerm))
        //        {
        //            var currentTask = _cts = new CancellationTokenSource();

        //            var movieService = AppleService.Instance.Value;
        //            var movies = await movieService.GetMoviesAsync(searchTerm);
        //            if (!currentTask.IsCancellationRequested)
        //            {
        //                Movies = new ObservableCollection<MovieResult>(movies?.Results?.Where(item => !string.IsNullOrWhiteSpace(item.TrackName)));
        //            }
        //        }
        //        else
        //        {
        //            Movies = null;
        //        }
        //    }
        //    finally
        //    {
        //        NoResults = Movies == null || Movies?.Count == 0;
        //        IsBusy = false;
        //    }
        //}
    }
}

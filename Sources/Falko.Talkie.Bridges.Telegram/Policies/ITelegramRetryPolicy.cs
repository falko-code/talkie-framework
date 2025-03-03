using Talkie.Bridges.Telegram.Exceptions;

namespace Talkie.Bridges.Telegram.Policies;

public interface ITelegramRetryPolicy
{
    ValueTask<bool> EvaluateAsync(TelegramException exception, CancellationToken cancellationToken);
}

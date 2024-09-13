using System.Diagnostics.SymbolStore;

namespace EventBus.WebApi;

public record JsonMessage(int Id, string Name,bool Tag);
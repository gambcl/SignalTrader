//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/cogamble/Projects/Personal/SignalTrader/SignalTrader/Signals/SignalScript/SignalScript.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace SignalTrader.Signals.SignalScript.Generated {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SignalScriptParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public interface ISignalScriptListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SignalScriptParser.signal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSignal([NotNull] SignalScriptParser.SignalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SignalScriptParser.signal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSignal([NotNull] SignalScriptParser.SignalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SignalScriptParser.signalblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSignalblock([NotNull] SignalScriptParser.SignalblockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SignalScriptParser.signalblock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSignalblock([NotNull] SignalScriptParser.SignalblockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SignalScriptParser.account"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAccount([NotNull] SignalScriptParser.AccountContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SignalScriptParser.account"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAccount([NotNull] SignalScriptParser.AccountContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SignalScriptParser.funclist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunclist([NotNull] SignalScriptParser.FunclistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SignalScriptParser.funclist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunclist([NotNull] SignalScriptParser.FunclistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SignalScriptParser.func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunc([NotNull] SignalScriptParser.FuncContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SignalScriptParser.func"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunc([NotNull] SignalScriptParser.FuncContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SignalScriptParser.namedparamlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamedparamlist([NotNull] SignalScriptParser.NamedparamlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SignalScriptParser.namedparamlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamedparamlist([NotNull] SignalScriptParser.NamedparamlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SignalScriptParser.namedparam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamedparam([NotNull] SignalScriptParser.NamedparamContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SignalScriptParser.namedparam"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamedparam([NotNull] SignalScriptParser.NamedparamContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>stringParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStringParamValue([NotNull] SignalScriptParser.StringParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>stringParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStringParamValue([NotNull] SignalScriptParser.StringParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>booleanParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanParamValue([NotNull] SignalScriptParser.BooleanParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>booleanParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanParamValue([NotNull] SignalScriptParser.BooleanParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>sideParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSideParamValue([NotNull] SignalScriptParser.SideParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>sideParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSideParamValue([NotNull] SignalScriptParser.SideParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>directionParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDirectionParamValue([NotNull] SignalScriptParser.DirectionParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>directionParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDirectionParamValue([NotNull] SignalScriptParser.DirectionParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>priceParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPriceParamValue([NotNull] SignalScriptParser.PriceParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>priceParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPriceParamValue([NotNull] SignalScriptParser.PriceParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>orderParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOrderParamValue([NotNull] SignalScriptParser.OrderParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>orderParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOrderParamValue([NotNull] SignalScriptParser.OrderParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>leverageParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLeverageParamValue([NotNull] SignalScriptParser.LeverageParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>leverageParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLeverageParamValue([NotNull] SignalScriptParser.LeverageParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>identifierParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierParamValue([NotNull] SignalScriptParser.IdentifierParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierParamValue([NotNull] SignalScriptParser.IdentifierParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>floatParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloatParamValue([NotNull] SignalScriptParser.FloatParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>floatParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloatParamValue([NotNull] SignalScriptParser.FloatParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>floatPercentParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloatPercentParamValue([NotNull] SignalScriptParser.FloatPercentParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>floatPercentParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloatPercentParamValue([NotNull] SignalScriptParser.FloatPercentParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>intParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntParamValue([NotNull] SignalScriptParser.IntParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>intParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntParamValue([NotNull] SignalScriptParser.IntParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>intPercentParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntPercentParamValue([NotNull] SignalScriptParser.IntPercentParamValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>intPercentParamValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.paramvalue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntPercentParamValue([NotNull] SignalScriptParser.IntPercentParamValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>trueValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTrueValue([NotNull] SignalScriptParser.TrueValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>trueValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTrueValue([NotNull] SignalScriptParser.TrueValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>falseValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFalseValue([NotNull] SignalScriptParser.FalseValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>falseValue</c>
	/// labeled alternative in <see cref="SignalScriptParser.boolean"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFalseValue([NotNull] SignalScriptParser.FalseValueContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>buySide</c>
	/// labeled alternative in <see cref="SignalScriptParser.side"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBuySide([NotNull] SignalScriptParser.BuySideContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>buySide</c>
	/// labeled alternative in <see cref="SignalScriptParser.side"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBuySide([NotNull] SignalScriptParser.BuySideContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>sellSide</c>
	/// labeled alternative in <see cref="SignalScriptParser.side"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSellSide([NotNull] SignalScriptParser.SellSideContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>sellSide</c>
	/// labeled alternative in <see cref="SignalScriptParser.side"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSellSide([NotNull] SignalScriptParser.SellSideContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>longDirection</c>
	/// labeled alternative in <see cref="SignalScriptParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLongDirection([NotNull] SignalScriptParser.LongDirectionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>longDirection</c>
	/// labeled alternative in <see cref="SignalScriptParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLongDirection([NotNull] SignalScriptParser.LongDirectionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>shortDirection</c>
	/// labeled alternative in <see cref="SignalScriptParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShortDirection([NotNull] SignalScriptParser.ShortDirectionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>shortDirection</c>
	/// labeled alternative in <see cref="SignalScriptParser.direction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShortDirection([NotNull] SignalScriptParser.ShortDirectionContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>bidPrice</c>
	/// labeled alternative in <see cref="SignalScriptParser.price"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBidPrice([NotNull] SignalScriptParser.BidPriceContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bidPrice</c>
	/// labeled alternative in <see cref="SignalScriptParser.price"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBidPrice([NotNull] SignalScriptParser.BidPriceContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>askPrice</c>
	/// labeled alternative in <see cref="SignalScriptParser.price"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAskPrice([NotNull] SignalScriptParser.AskPriceContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>askPrice</c>
	/// labeled alternative in <see cref="SignalScriptParser.price"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAskPrice([NotNull] SignalScriptParser.AskPriceContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>lastPrice</c>
	/// labeled alternative in <see cref="SignalScriptParser.price"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLastPrice([NotNull] SignalScriptParser.LastPriceContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>lastPrice</c>
	/// labeled alternative in <see cref="SignalScriptParser.price"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLastPrice([NotNull] SignalScriptParser.LastPriceContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>marketOrder</c>
	/// labeled alternative in <see cref="SignalScriptParser.order"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMarketOrder([NotNull] SignalScriptParser.MarketOrderContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>marketOrder</c>
	/// labeled alternative in <see cref="SignalScriptParser.order"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMarketOrder([NotNull] SignalScriptParser.MarketOrderContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>limitOrder</c>
	/// labeled alternative in <see cref="SignalScriptParser.order"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLimitOrder([NotNull] SignalScriptParser.LimitOrderContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>limitOrder</c>
	/// labeled alternative in <see cref="SignalScriptParser.order"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLimitOrder([NotNull] SignalScriptParser.LimitOrderContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>crossLeverage</c>
	/// labeled alternative in <see cref="SignalScriptParser.leverage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCrossLeverage([NotNull] SignalScriptParser.CrossLeverageContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>crossLeverage</c>
	/// labeled alternative in <see cref="SignalScriptParser.leverage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCrossLeverage([NotNull] SignalScriptParser.CrossLeverageContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>isolatedLeverage</c>
	/// labeled alternative in <see cref="SignalScriptParser.leverage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIsolatedLeverage([NotNull] SignalScriptParser.IsolatedLeverageContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>isolatedLeverage</c>
	/// labeled alternative in <see cref="SignalScriptParser.leverage"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIsolatedLeverage([NotNull] SignalScriptParser.IsolatedLeverageContext context);
}
} // namespace SignalTrader.Signals.SignalScript.Generated

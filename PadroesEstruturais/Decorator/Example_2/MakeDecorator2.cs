using System.Data;

public abstract class Componente
{
    public abstract string Operacao();
}

class ComponenteConcreto : Componente
{
    public override string Operacao()
    {
        return null;
    }
}

abstract class Decorator : Componente
{
    protected Componente componente;

    public Decorator(Componente componente)
    {
        this.componente = componente;
    }

    public override string Operacao()
    {
        if (this.componente != null)
        {
            return this.componente.Operacao();
        }
        else
        {
            return string.Empty;
        }
    }
}

class DecoratorA : Decorator
{

    public DecoratorA(Componente componente) : base(componente)
    {
    }

    public override string Operacao()
    {
        return $"Notificação Facebook({base.Operacao()})";
    }
}

class DecoratorB : Decorator
{
    public DecoratorB(Componente comp) : base(comp)
    {
    }

    public override string Operacao()
    {
        return $"Notificação WhatsApp({base.Operacao()})";
    }
}

public class Cliente
{
    public void CodigodoCliente(Componente componente)
    {
        Console.WriteLine("RESULTADO: " + componente.Operacao());
    }
}

public class MakeDecorator2
{
    public static void make()
    {
        Cliente cliente = new Cliente();
        var sms = new ComponenteConcreto();
        DecoratorA facebook = new DecoratorA(sms);
        DecoratorB whatsapp = new DecoratorB(facebook);

        DecoratorB decoratorNew = new DecoratorB(sms);

        cliente.CodigodoCliente(sms);
        cliente.CodigodoCliente(facebook);
        cliente.CodigodoCliente(whatsapp);
        cliente.CodigodoCliente(decoratorNew);

    }
}
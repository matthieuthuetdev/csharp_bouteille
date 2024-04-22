public class Bouteille
{
    private double capaciteMaxEnMl;
    private bool estOuverte;
    private double quantiteLiquideEnMl;
    private DateTime dateDePeremption;

    // Constructeur par défaut
    public Bouteille()
    {
        this.capaciteMaxEnMl = 1000;
        this.estOuverte = false;
        this.quantiteLiquideEnMl = 1000;
        this.dateDePeremption = DateTime.MaxValue;
    }

    // Constructeur avec capacité et date de péremption
    public Bouteille(double _capaciteMaxEnMl, DateTime _dateDePeremption) : this(_capaciteMaxEnMl, false, _capaciteMaxEnMl, _dateDePeremption)
    {

    }

    // Constructeur complet
    public Bouteille(double _capaciteMaxEnMl, bool _estOuverte, double _quantiteLiquideEnMl, DateTime _dateDePeremption)
    {
        this.capaciteMaxEnMl = _capaciteMaxEnMl;
        this.estOuverte = _estOuverte;
        this.quantiteLiquideEnMl = _quantiteLiquideEnMl;
        this.dateDePeremption = _dateDePeremption;
    }
    public bool fermer()
    {
            if(estOuverte)
        {
            this.estOuverte = false;
        }
        else { this.estOuverte = true;
               }
            return this.estOuverte;
    }
    public bool fermer()
    {
        if (this.estOuverte == false)
        {
            this.estOuverte = true;
        }
        else
        {
            this.estOuverte = true;
        }
        return this.estOuverte;
    }
}


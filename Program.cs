using DesignPatterns.Observer;

var onlineMarketplace = new OnlineMarketplace();

var khaled = new Customer("Khaled");
var youssef = new Customer("Youssef");
var zyad = new Customer("Zyad");

onlineMarketplace.Subscribe(EventType.NEW_PRODUCT, khaled);
onlineMarketplace.Subscribe(EventType.NEW_OFFER, khaled);
onlineMarketplace.Subscribe(EventType.NEW_PRODUCT, youssef);
onlineMarketplace.Subscribe(EventType.NEW_OFFER, zyad);

onlineMarketplace.AddProduct(new Product("Mobile", 1000));

onlineMarketplace.AddOffer(new Offer("new offer with 20% off for all items!"));
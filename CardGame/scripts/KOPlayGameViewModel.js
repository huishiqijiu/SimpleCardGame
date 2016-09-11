var KOPlayGameViewModel = function (data) {
    var self = this;
    if (data != null) {
        ko.mapping.fromJS(data, { CardsFaceDown: cardModelMapping }, self);
    } else {
        self.CardsFaceDown = ko.observableArray();
        self.NumberOfDecks = ko.observable();
        self.CardFlippedUp = ko.observable();
    }    
    self.ShuffleCards = function () {        
        $('#flipBtn').show();
        //var obj = ko.mapping.toJSON(self);
        //$.ajax({
        //    url: "/PlayGame/ShuffleCards?numOfDecks=" + self.NumberOfDecks(),
        //    type: "Post",
        //    data: obj,
        //    contentType: "application/json",
        //    success: function (result) {
        //        self.CardsFaceDown = ko.observableArray(result);
        //        console.log(self.CardsFaceDown());
        //        cardsFaceDown = self.CardsFaceDown();
        //        console.log(cardsFaceDown[0]);
        //        //console.log(self.CardsFaceDown());
        //    }
        //})        
        function shuffle(a) {
            var j, x, i;
            for (i = a.length; i; i--) {
                j = Math.floor(Math.random() * i);
                x = a[i - 1];
                a[i - 1] = a[j];
                a[j] = x;
            }
        }
        cardsFaceDown = self.CardsFaceDown();
        console.log(cardsFaceDown);
        shuffle(cardsFaceDown);
        console.log(cardsFaceDown);
    }
    self.SortCards = function () {        
        //var obj = ko.mapping.toJSON(self);
        //$.ajax({
        //    url: "/PlayGame/SortCards?numOfDecks=" + self.NumberOfDecks(),
        //    type: "Post",
        //    data: obj,
        //    contentType: "application/json",
        //    success: function (result) {
        //        self.CardsFaceDown = ko.observableArray((result));
        //        console.log(self.CardsFaceDown());
        //        cardsFaceDown = self.CardsFaceDown();
        //    }
        //})
        cardsFaceDown = self.CardsFaceDown();
        cardsFaceDown.sort(function (a, b) {
            return a.Id() - b.Id();
        })
        console.log(cardsFaceDown);
    }    
    self.FlipACard = function () {
        var flippedCard = new CardModel();        
        if (cardsFaceDown == null)
        {            
            cardsFaceDown = self.CardsFaceDown();
        }       
            flippedCard = cardsFaceDown[0];
            console.log(flippedCard);
            $('#openCard').show();
            $('#openCard').css("box-shadow", "0 4px 8px 0 rgba(0,0,0,0.2)");
            $('#openCard').css("background-color", "white");
            if (flippedCard.Number() == 1)
                $('#cardValue').text("A");
            else if (flippedCard.Number() == 11)
                $('#cardValue').text("J");
            else if (flippedCard.Number() == 12)
                $('#cardValue').text("Q");
            else if (flippedCard.Number() == 13)
                $('#cardValue').text("K");
            else
                $('#cardValue').text(flippedCard.Number());

            if (flippedCard.Color() == "Heart")
                $('#cardSuit').attr("src", "/Images/Heart.jpg");
            else if (flippedCard.Color()== "Spade")
                $('#cardSuit').attr("src", "/Images/Spade.jpg");
            else if (flippedCard.Color() == "Diamond")
                $('#cardSuit').attr("src", "/Images/Diamond.jpg");
            else if (flippedCard.Color() == "Club")
                $('#cardSuit').attr("src", "/Images/Club.jpg");
            else
                $('#cardSuit').attr("src", "/Images/Blank.png");
            if (($('#cardValue').text() == "Q") && ($('#cardSuit').attr("src") == "/Images/Heart.jpg")) {
                setTimeout(function () { $('#myModal').modal('show'); }, 200);
            }
            cardsFaceDown.splice(cardsFaceDown.indexOf(flippedCard), 1);
            if (cardsFaceDown.length == 0) {
                $('#flipBtn').hide();
                cardsFaceDown = self.CardsFaceDown();
                $('#openCard').hide()
            }
    }
};
var cardModelMapping = {
    create: function (options) {
        return new CardModel(options.data);
    }
};
var CardModel = function (data) {

    var self = this;
    if (data != null) {
        ko.mapping.fromJS(data, {}, self);
    } else {
        self.Id = ko.observable();
        self.Color = ko.observable();
        self.Number = ko.observable();
        self.IsFlippedUp = ko.observable();
    } 
};

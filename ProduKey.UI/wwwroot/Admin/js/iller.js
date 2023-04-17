var data = [{"il": "Adana"},{"il": "Adıyaman"},{"il": "Afyonkarahisar"},{"il": "Ağrı"},
  {
    "il": "Amasya"
  },
  {
    "il": "Ankara"
  },
  {
    "il": "Antalya"
  },
  {
    "il": "Artvin"
  },
  {
    "il": "Aydın"
  },
  {
    "il": "Balıkesir"
  },
  {
    "il": "Bilecik"
  },
  {
    "il": "Bingöl"
  },
  {
    "il": "Bitlis"
  },
  {
    "il": "Bolu"
  },
  {
    "il": "Burdur"
  },
  {
    "il": "Bursa"
  },
  {
    "il": "Çanakkale"
  },
  {
    "il": "Çankırı"
  },
  {
    "il": "Çorum"
  },
  {
    "il": "Denizli"
  },
  {
    "il": "Diyarbakır"
  },
  {
    "il": "Edirne"
  },
  {
    "il": "Elazığ"
  },
  {
    "il": "Erzincan"
  },
  {
    "il": "Erzurum"
  },
  {
    "il": "Eskişehir"
  },
  {
    "il": "Gaziantep"
  },
  {
    "il": "Giresun"
  },
  {
    "il": "Gümüşhane"
  },
  {
    "il": "Hakkari"
  },
  {
    "il": "Hatay"
  },
  {
    "il": "Isparta"
  },
  {
    "il": "Mersin"
  },
  {
    "il": "İstanbul"
  },
  {
    "il": "İzmir"
  },
  {
    "il": "Kars"
  },
  {
    "il": "Kastamonu"
  },
  {
    "il": "Kayseri"
  },
  {
    "il": "Kırklareli"
  },
  {
    "il": "Kırşehir"
  },
  {
    "il": "Kocaeli"
  },
  {
    "il": "Konya"
  },
  {
    "il": "Kütahya"
  },
  {
    "il": "Malatya"
  },
  {
    "il": "Manisa"
  },
  {
    "il": "Kahramanmaraş"
  },
  {
    "il": "Mardin"
  },
  {
    "il": "Muğla"
  },
  {
    "il": "Muş"
  },
  {
    "il": "Nevşehir"
  },
  {
    "il": "Niğde"
  },
  {
    "il": "Ordu"
  },
  {
    "il": "Rize"
  },
  {
    "il": "Sakarya"
  },
  {
    "il": "Samsun"
  },
  {
    "il": "Siirt"
  },
  {
    "il": "Sinop"
  },
  {
    "il": "Sivas"
  },
  {
    "il": "Tekirdağ"
  },
  {
    "il": "Tokat"
  },
  {
    "il": "Trabzon"
  },
  {
    "il": "Tunceli"
  },
  {
    "il": "Şanlıurfa"
  },
  {
    "il": "Uşak"
  },
  {
    "il": "Van"
  },
  {
    "il": "Yozgat"
  },
  {
    "il": "Zonguldak"
  },
  {
    "il": "Aksaray"
  },
  {
    "il": "Bayburt"
  },
  {
    "il": "Karaman"
  },
  {
    "il": "Kırıkkale"
  },
  {
    "il": "Batman"
  },
  {
    "il": "Şırnak"
  },
  {
    "il": "Bartın"
  },
  {
    "il": "Ardahan"
  },
  {
    "il": "Iğdır"
  },
  {
    "il": "Yalova"
  },
  {
    "il": "Karabük"
  },
  {
    "il": "Kilis"
  },
  {
    "il": "Osmaniye"
  },
  {
    "il": "Düzce"
  }
]

$( document ).ready(function() {
    $.each(data, function (index, value) {
        jQuery('#Iller').append($('<option>', {
        value: value.il,
        text:  value.il
    }));
  });
});



    
            var bolge = [{
                    "bolge": "Akdeniz"
                },
                {
                    "bolge": "Doğu Anadolu"
                },
                {
                    "bolge": "Ege"
                },
                {
                    "bolge": "Güneydoğu Anadolu"
                },
                {
                    "bolge": "İç Anadolu"
                },
                {
                    "bolge": "Marmara"
                },
                {
                    "bolge": "Karadeniz"
                }
            ]

            $(document).ready(function() {
                $.each(bolge, function (index, value) {
                      jQuery('#bolge').append($('<option>', {
                        value: value.bolge,
                        text: value.bolge
                    }));
                });
            });






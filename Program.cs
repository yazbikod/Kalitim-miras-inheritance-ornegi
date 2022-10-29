using Kalitim_miras_inheritance_ornegi;

PersonelOzlukTaslak PersonelOzlukTaslak = new PersonelOzlukTaslak();
PersonelOzlukTaslak.PersonelKayit("1354","Murat","Han", "Memur");
PersonelOzlukTaslak.PerBilgiAl();

PerMaasTaslak zamyap = new PerMaasTaslak();
zamyap.MaasBilgiGoster();
zamyap.ZamYapDirek(1250);
zamyap.ZamyapYuzde(22);
zamyap.MaasBilgiGoster();

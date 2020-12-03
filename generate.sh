#!/usr/bin/env bash
outdir=Generated
sourcever=3.5.0
url=https://github.com/fpaquet/gtksheet/archive/V$sourcever.tar.gz
localfile=gtksheet-v$sourcever.tar.gz

wget $url -O $localfile
tar xf $localfile

if [ -d $outdir ];
then
    rm -rf $outdir
fi

../GtkSharp/Source/OldStuff/parser/gapi-parser SourceView.source

rm $localfile
rm -rf $localfile

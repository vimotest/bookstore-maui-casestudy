<?xml version="1.0" encoding="UTF-8"?>
<model ref="r:6b8cf5df-c890-498c-b8f0-cb5752ca8635(BookStoreViMoTests.tests)">
  <persistence version="9" />
  <languages>
    <devkit ref="d1a914ef-09af-4c66-a6d1-618e1f9114ea(de.vimotest.devkit)" />
  </languages>
  <imports />
  <registry>
    <language id="611ecc9e-0703-4ab9-a13c-fb396c607716" name="de.vimotest.types">
      <concept id="777152910168881023" name="de.vimotest.types.structure.AbstractStructType" flags="ng" index="103Zsb">
        <child id="777152910168882908" name="contents" index="103ZUC" />
      </concept>
      <concept id="777152910168882295" name="de.vimotest.types.structure.EmptyStructContent" flags="ng" index="103ZK3" />
    </language>
    <language id="ceab5195-25ea-4f22-9b92-103b95ca8c0c" name="jetbrains.mps.lang.core">
      <concept id="1169194658468" name="jetbrains.mps.lang.core.structure.INamedConcept" flags="ngI" index="TrEIO">
        <property id="1169194664001" name="name" index="TrG5h" />
      </concept>
    </language>
    <language id="ce7915b5-36b4-4478-a67c-f5a8a72ed4a0" name="de.vimotest.viewmodel">
      <concept id="9155943921465570409" name="de.vimotest.viewmodel.structure.SelectedRowFeature" flags="ng" index="1i$ol" />
      <concept id="3922717397912187187" name="de.vimotest.viewmodel.structure.ImageWidget" flags="ng" index="2mJbI3">
        <child id="3922717397912187188" name="imageSourceFeature" index="2mJbI4" />
        <child id="3922717397912187189" name="enabledFeature" index="2mJbI5" />
        <child id="3922717397912187190" name="visibilityFeature" index="2mJbI6" />
      </concept>
      <concept id="3922717397912187178" name="de.vimotest.viewmodel.structure.ImageSourceFeature" flags="ng" index="2mJbIq">
        <child id="173640931447457367" name="defaultImage" index="3n32fm" />
      </concept>
      <concept id="5219625661134590255" name="de.vimotest.viewmodel.structure.SingleOrMultiLineString" flags="ng" index="o7Kjd">
        <property id="5219625661134591033" name="singleLineValue" index="o7K7r" />
      </concept>
      <concept id="5213916851000129487" name="de.vimotest.viewmodel.structure.CheckedFeature" flags="ng" index="C4FCf" />
      <concept id="5213916851000129488" name="de.vimotest.viewmodel.structure.VisibilityFeature" flags="ng" index="C4FCg" />
      <concept id="5213916851000129489" name="de.vimotest.viewmodel.structure.EnabledFeature" flags="ng" index="C4FCh" />
      <concept id="5213916851000129514" name="de.vimotest.viewmodel.structure.CheckBoxWidget" flags="ng" index="C4FCE">
        <child id="5213916851000129515" name="checkedFeature" index="C4FCF" />
        <child id="5213916851000129516" name="visibilityFeature" index="C4FCG" />
        <child id="5213916851000129517" name="enabledFeature" index="C4FCH" />
        <child id="1938192778486065161" name="checkCommand" index="T1B0p" />
        <child id="7278489671513126078" name="textFeature" index="1ISttP" />
      </concept>
      <concept id="471139930089728146" name="de.vimotest.viewmodel.structure.TableColumnWidget" flags="ng" index="E2vJn">
        <child id="471139930089728148" name="enabledFeature" index="E2vJh" />
        <child id="471139930089728147" name="textFeature" index="E2vJm" />
        <child id="471139930095592890" name="widgetType" index="Ek7rZ" />
        <child id="471139930095530076" name="visibilityFeature" index="Ekmcp" />
      </concept>
      <concept id="8882441622785832542" name="de.vimotest.viewmodel.structure.TextFeature" flags="ng" index="V3Zf6">
        <child id="5219625661134947434" name="defaultText" index="o6p68" />
      </concept>
      <concept id="8882441622785832551" name="de.vimotest.viewmodel.structure.LabelWidget" flags="ng" index="V3ZfZ">
        <child id="8882441622785832552" name="textFeature" index="V3ZfK" />
        <child id="8882441622785832553" name="enabledFeature" index="V3ZfL" />
        <child id="8882441622785832554" name="visibilityFeature" index="V3ZfM" />
        <child id="5775867078593479453" name="textColorFeature" index="31m0es" />
        <child id="7922086861330453416" name="toolTipFeature" index="1G_fIJ" />
      </concept>
      <concept id="6201744883139140301" name="de.vimotest.viewmodel.structure.ButtonWidget" flags="ng" index="2X2XNh">
        <child id="6201744883139140304" name="visibilityFeature" index="2X2XNc" />
        <child id="6201744883139140305" name="clickCommand" index="2X2XNd" />
        <child id="6201744883139140302" name="textFeature" index="2X2XNi" />
        <child id="6201744883139140303" name="enabledFeature" index="2X2XNj" />
      </concept>
      <concept id="777152910168882965" name="de.vimotest.viewmodel.structure.ViewModelCommands" flags="ng" index="103ZXx">
        <child id="777152910169039599" name="commands" index="1006ar" />
      </concept>
      <concept id="777152910168882960" name="de.vimotest.viewmodel.structure.ViewModel" flags="ng" index="103ZX$">
        <child id="777152910168882972" name="viewModelCommands" index="103ZXC" />
        <child id="777152910168882975" name="viewModelData" index="103ZXF" />
      </concept>
      <concept id="777152910168882963" name="de.vimotest.viewmodel.structure.ViewModelData" flags="ng" index="103ZXB" />
      <concept id="5775867078593476371" name="de.vimotest.viewmodel.structure.TextColorFeature" flags="ng" index="31hZui" />
      <concept id="2820520252859978186" name="de.vimotest.viewmodel.structure.ImageDefinitionRef" flags="ng" index="3eDL7N" />
      <concept id="2148949417128514166" name="de.vimotest.viewmodel.structure.IRowBasedFeature" flags="ngI" index="3_UcxH">
        <child id="4610291257172520368" name="rowHandleFeature" index="3D86r8" />
        <child id="4610291257172520369" name="updatingRowsFlagFeature" index="3D86r9" />
      </concept>
      <concept id="4610291257172366649" name="de.vimotest.viewmodel.structure.RowHandleCustomFeature" flags="ng" index="3D8xT1">
        <property id="6327146089782817145" name="kind" index="34jNyx" />
      </concept>
      <concept id="4610291257172397388" name="de.vimotest.viewmodel.structure.UpdatingRowsFlagCustomFeature" flags="ng" index="3D8CoO" />
      <concept id="7922086861330453131" name="de.vimotest.viewmodel.structure.ToolTipFeature" flags="ng" index="1G_fEc">
        <child id="7922086861494473183" name="defaultToolTipText" index="1AQzBo" />
      </concept>
      <concept id="2690363995917909073" name="de.vimotest.viewmodel.structure.WidgetTableRowsFeature" flags="ng" index="3KuuIt" />
      <concept id="2392128244454154631" name="de.vimotest.viewmodel.structure.TableViewWidget" flags="ng" index="3UVeDL">
        <child id="471139930089728593" name="tableColumnWidgets" index="E2v$k" />
        <child id="2392128244454154634" name="visibilityFeature" index="3UVeDW" />
        <child id="2392128244454154635" name="enabledFeature" index="3UVeDX" />
        <child id="2392128244454154632" name="widgetTableRowsFeature" index="3UVeDY" />
        <child id="2392128244454154633" name="selectedRowFeature" index="3UVeDZ" />
      </concept>
      <concept id="7283258543666616094" name="de.vimotest.viewmodel.structure.CheckCommand" flags="ng" index="3Vw88g" />
      <concept id="7283258543666616095" name="de.vimotest.viewmodel.structure.ClickCommand" flags="ng" index="3Vw88h" />
      <concept id="7283258543666616097" name="de.vimotest.viewmodel.structure.LoadCommand" flags="ng" index="3Vw88J" />
    </language>
  </registry>
  <node concept="103ZX$" id="6VfcGNTv8_R">
    <property role="TrG5h" value="BookListViewModel" />
    <node concept="103ZXx" id="6VfcGNTv8_S" role="103ZXC">
      <node concept="3Vw88J" id="6VfcGNTv8_T" role="1006ar">
        <property role="TrG5h" value="LoadView" />
      </node>
    </node>
    <node concept="103ZXB" id="6VfcGNTv8_U" role="103ZXF">
      <node concept="2X2XNh" id="6N2ZkRtozvB" role="103ZUC">
        <property role="TrG5h" value="Add" />
        <node concept="3Vw88h" id="6N2ZkRtozvC" role="2X2XNd" />
        <node concept="V3Zf6" id="6N2ZkRtozvE" role="2X2XNi">
          <node concept="o7Kjd" id="6N2ZkRtozvG" role="o6p68">
            <property role="o7K7r" value="Add to cart" />
          </node>
        </node>
        <node concept="C4FCh" id="6N2ZkRtozvI" role="2X2XNj" />
        <node concept="C4FCg" id="6N2ZkRtozvK" role="2X2XNc" />
      </node>
      <node concept="2X2XNh" id="6N2ZkRtozvN" role="103ZUC">
        <property role="TrG5h" value="Delete" />
        <node concept="3Vw88h" id="6N2ZkRtozvO" role="2X2XNd" />
        <node concept="V3Zf6" id="6N2ZkRtozvQ" role="2X2XNi">
          <node concept="o7Kjd" id="6N2ZkRtozvS" role="o6p68">
            <property role="o7K7r" value="Remove from cart" />
          </node>
        </node>
        <node concept="C4FCh" id="6N2ZkRtozvU" role="2X2XNj" />
        <node concept="C4FCg" id="6N2ZkRtozvW" role="2X2XNc" />
      </node>
      <node concept="103ZK3" id="6N2ZkRtozvY" role="103ZUC" />
      <node concept="3UVeDL" id="6VfcGNTv8A9" role="103ZUC">
        <property role="TrG5h" value="BookList" />
        <node concept="E2vJn" id="6N2ZkRtozw0" role="E2v$k">
          <node concept="V3Zf6" id="6N2ZkRtozw1" role="E2vJm">
            <node concept="o7Kjd" id="6N2ZkRtozw2" role="o6p68" />
          </node>
          <node concept="C4FCg" id="6N2ZkRtozw3" role="Ekmcp" />
          <node concept="C4FCh" id="6N2ZkRtozw4" role="E2vJh" />
          <node concept="C4FCE" id="6N2ZkRtozw6" role="Ek7rZ">
            <property role="TrG5h" value="Selected" />
            <node concept="3Vw88g" id="6N2ZkRtozw7" role="T1B0p" />
            <node concept="C4FCf" id="6N2ZkRtozw9" role="C4FCF" />
            <node concept="C4FCg" id="6N2ZkRtozwb" role="C4FCG" />
            <node concept="C4FCh" id="6N2ZkRtozwd" role="C4FCH" />
            <node concept="V3Zf6" id="6N2ZkRtozwf" role="1ISttP">
              <node concept="o7Kjd" id="6N2ZkRtozwh" role="o6p68" />
            </node>
          </node>
        </node>
        <node concept="E2vJn" id="6VfcGNTv8Aa" role="E2v$k">
          <node concept="V3Zf6" id="6VfcGNTv8Ab" role="E2vJm">
            <node concept="o7Kjd" id="6VfcGNTv8Ac" role="o6p68">
              <property role="o7K7r" value="ID" />
            </node>
          </node>
          <node concept="C4FCg" id="6VfcGNTv8Ad" role="Ekmcp" />
          <node concept="C4FCh" id="6VfcGNTv8Ae" role="E2vJh" />
          <node concept="V3ZfZ" id="6N2ZkRtozxg" role="Ek7rZ">
            <property role="TrG5h" value="ID" />
            <node concept="V3Zf6" id="6N2ZkRtozxm" role="V3ZfK">
              <node concept="o7Kjd" id="6N2ZkRtozxs" role="o6p68" />
            </node>
            <node concept="C4FCh" id="6N2ZkRtozxy" role="V3ZfL" />
            <node concept="C4FCg" id="6N2ZkRtozxC" role="V3ZfM" />
            <node concept="1G_fEc" id="6N2ZkRtozxI" role="1G_fIJ">
              <node concept="o7Kjd" id="6N2ZkRtozxO" role="1AQzBo" />
            </node>
            <node concept="31hZui" id="6N2ZkRtozxU" role="31m0es" />
          </node>
        </node>
        <node concept="3KuuIt" id="6VfcGNTv8Aw" role="3UVeDY">
          <node concept="3D8xT1" id="6VfcGNTv8Ax" role="3D86r8">
            <property role="34jNyx" value="1RiAxJSewmn/StringRowHandle" />
          </node>
          <node concept="3D8CoO" id="6VfcGNTv8Ay" role="3D86r9" />
        </node>
        <node concept="1i$ol" id="6VfcGNTv8Az" role="3UVeDZ" />
        <node concept="C4FCg" id="6VfcGNTv8A$" role="3UVeDW" />
        <node concept="C4FCh" id="6VfcGNTv8A_" role="3UVeDX" />
        <node concept="E2vJn" id="6N2ZkRtozwj" role="E2v$k">
          <node concept="V3Zf6" id="6N2ZkRtozwk" role="E2vJm">
            <node concept="o7Kjd" id="6N2ZkRtozwl" role="o6p68" />
          </node>
          <node concept="C4FCg" id="6N2ZkRtozwm" role="Ekmcp" />
          <node concept="C4FCh" id="6N2ZkRtozwn" role="E2vJh" />
          <node concept="2mJbI3" id="6N2ZkRtozx6" role="Ek7rZ">
            <property role="TrG5h" value="Preview" />
            <node concept="2mJbIq" id="6N2ZkRtozx8" role="2mJbI4">
              <node concept="3eDL7N" id="6N2ZkRtozxa" role="3n32fm" />
            </node>
            <node concept="C4FCh" id="6N2ZkRtozxc" role="2mJbI5" />
            <node concept="C4FCg" id="6N2ZkRtozxe" role="2mJbI6" />
          </node>
        </node>
        <node concept="E2vJn" id="6VfcGNTv8AA" role="E2v$k">
          <node concept="V3Zf6" id="6VfcGNTv8AB" role="E2vJm">
            <node concept="o7Kjd" id="6VfcGNTv8AC" role="o6p68">
              <property role="o7K7r" value="Title" />
            </node>
          </node>
          <node concept="C4FCg" id="6VfcGNTv8AD" role="Ekmcp" />
          <node concept="C4FCh" id="6VfcGNTv8AE" role="E2vJh" />
          <node concept="V3ZfZ" id="6VfcGNTv8AG" role="Ek7rZ">
            <property role="TrG5h" value="Title" />
            <node concept="V3Zf6" id="6VfcGNTv8AI" role="V3ZfK">
              <node concept="o7Kjd" id="6VfcGNTv8AK" role="o6p68" />
            </node>
            <node concept="C4FCh" id="6VfcGNTv8AM" role="V3ZfL" />
            <node concept="C4FCg" id="6VfcGNTv8AO" role="V3ZfM" />
            <node concept="1G_fEc" id="6VfcGNTv8AQ" role="1G_fIJ">
              <node concept="o7Kjd" id="6VfcGNTv8AS" role="1AQzBo" />
            </node>
            <node concept="31hZui" id="6VfcGNTv8AU" role="31m0es" />
          </node>
        </node>
        <node concept="E2vJn" id="6VfcGNTv8AW" role="E2v$k">
          <node concept="V3Zf6" id="6VfcGNTv8AX" role="E2vJm">
            <node concept="o7Kjd" id="6VfcGNTv8AY" role="o6p68">
              <property role="o7K7r" value="Author" />
            </node>
          </node>
          <node concept="C4FCg" id="6VfcGNTv8AZ" role="Ekmcp" />
          <node concept="C4FCh" id="6VfcGNTv8B0" role="E2vJh" />
          <node concept="V3ZfZ" id="6VfcGNTv8B1" role="Ek7rZ">
            <property role="TrG5h" value="Author" />
            <node concept="V3Zf6" id="6VfcGNTv8B2" role="V3ZfK">
              <node concept="o7Kjd" id="6VfcGNTv8B3" role="o6p68" />
            </node>
            <node concept="C4FCh" id="6VfcGNTv8B4" role="V3ZfL" />
            <node concept="C4FCg" id="6VfcGNTv8B5" role="V3ZfM" />
            <node concept="1G_fEc" id="6VfcGNTv8B6" role="1G_fIJ">
              <node concept="o7Kjd" id="6VfcGNTv8B7" role="1AQzBo" />
            </node>
            <node concept="31hZui" id="6VfcGNTv8B8" role="31m0es" />
          </node>
        </node>
        <node concept="E2vJn" id="6VfcGNTv8B9" role="E2v$k">
          <node concept="V3Zf6" id="6VfcGNTv8Ba" role="E2vJm">
            <node concept="o7Kjd" id="6VfcGNTv8Bb" role="o6p68">
              <property role="o7K7r" value="ISBN" />
            </node>
          </node>
          <node concept="C4FCg" id="6VfcGNTv8Bc" role="Ekmcp" />
          <node concept="C4FCh" id="6VfcGNTv8Bd" role="E2vJh" />
          <node concept="V3ZfZ" id="6VfcGNTv8Be" role="Ek7rZ">
            <property role="TrG5h" value="ISBN" />
            <node concept="V3Zf6" id="6VfcGNTv8Bf" role="V3ZfK">
              <node concept="o7Kjd" id="6VfcGNTv8Bg" role="o6p68" />
            </node>
            <node concept="C4FCh" id="6VfcGNTv8Bh" role="V3ZfL" />
            <node concept="C4FCg" id="6VfcGNTv8Bi" role="V3ZfM" />
            <node concept="1G_fEc" id="6VfcGNTv8Bj" role="1G_fIJ">
              <node concept="o7Kjd" id="6VfcGNTv8Bk" role="1AQzBo" />
            </node>
            <node concept="31hZui" id="6VfcGNTv8Bl" role="31m0es" />
          </node>
        </node>
        <node concept="E2vJn" id="6VfcGNTv8Bm" role="E2v$k">
          <node concept="V3Zf6" id="6VfcGNTv8Bn" role="E2vJm">
            <node concept="o7Kjd" id="6VfcGNTv8Bo" role="o6p68">
              <property role="o7K7r" value="Price" />
            </node>
          </node>
          <node concept="C4FCg" id="6VfcGNTv8Bp" role="Ekmcp" />
          <node concept="C4FCh" id="6VfcGNTv8Bq" role="E2vJh" />
          <node concept="V3ZfZ" id="6VfcGNTv8Br" role="Ek7rZ">
            <property role="TrG5h" value="Price" />
            <node concept="V3Zf6" id="6VfcGNTv8Bs" role="V3ZfK">
              <node concept="o7Kjd" id="6VfcGNTv8Bt" role="o6p68" />
            </node>
            <node concept="C4FCh" id="6VfcGNTv8Bu" role="V3ZfL" />
            <node concept="C4FCg" id="6VfcGNTv8Bv" role="V3ZfM" />
            <node concept="1G_fEc" id="6VfcGNTv8Bw" role="1G_fIJ">
              <node concept="o7Kjd" id="6VfcGNTv8Bx" role="1AQzBo" />
            </node>
            <node concept="31hZui" id="6VfcGNTv8By" role="31m0es" />
          </node>
        </node>
        <node concept="E2vJn" id="6VfcGNTv8Bz" role="E2v$k">
          <node concept="V3Zf6" id="6VfcGNTv8B$" role="E2vJm">
            <node concept="o7Kjd" id="6VfcGNTv8B_" role="o6p68">
              <property role="o7K7r" value="Stock" />
            </node>
          </node>
          <node concept="C4FCg" id="6VfcGNTv8BA" role="Ekmcp" />
          <node concept="C4FCh" id="6VfcGNTv8BB" role="E2vJh" />
          <node concept="V3ZfZ" id="6VfcGNTv8BC" role="Ek7rZ">
            <property role="TrG5h" value="Stock" />
            <node concept="V3Zf6" id="6VfcGNTv8BD" role="V3ZfK">
              <node concept="o7Kjd" id="6VfcGNTv8BE" role="o6p68" />
            </node>
            <node concept="C4FCh" id="6VfcGNTv8BF" role="V3ZfL" />
            <node concept="C4FCg" id="6VfcGNTv8BG" role="V3ZfM" />
            <node concept="1G_fEc" id="6VfcGNTv8BH" role="1G_fIJ">
              <node concept="o7Kjd" id="6VfcGNTv8BI" role="1AQzBo" />
            </node>
            <node concept="31hZui" id="6VfcGNTv8BJ" role="31m0es" />
          </node>
        </node>
      </node>
    </node>
  </node>
  <node concept="103ZX$" id="6VfcGNTv8_V">
    <property role="TrG5h" value="BookDetailsViewModel" />
    <node concept="103ZXx" id="6VfcGNTv8_W" role="103ZXC">
      <node concept="3Vw88J" id="6VfcGNTv8_X" role="1006ar">
        <property role="TrG5h" value="LoadView" />
      </node>
    </node>
    <node concept="103ZXB" id="6VfcGNTv8_Y" role="103ZXF" />
  </node>
  <node concept="103ZX$" id="6VfcGNTv8_Z">
    <property role="TrG5h" value="BookTreeViewModel" />
    <node concept="103ZXx" id="6VfcGNTv8A0" role="103ZXC">
      <node concept="3Vw88J" id="6VfcGNTv8A1" role="1006ar">
        <property role="TrG5h" value="LoadView" />
      </node>
    </node>
    <node concept="103ZXB" id="6VfcGNTv8A2" role="103ZXF" />
  </node>
</model>


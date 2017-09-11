﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb


{

  
    public class pdf : ContentPage
    {
        private ListView _pharmacylist;
        private string name;
        private string _name;
        private string _description;
        public void refresh()
        {
        }
        
    

        public pdf()
        {

            BackgroundColor = Color.White;
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();


            var st = 
               "<body>" +
               "<div style = 'position:absolute;left:50%;margin-left:-297px;top:0px;width:595px;height:841px;border-style:outset;overflow:hidden' >" +
                "<div style = 'position:absolute;left:0px;top:0px' >" +
                 "< img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background01.jpg' width = 595 height = 841 ></ div >" +
                      "<div style = 'position:absolute;left:114.50px;top:88.86px' class='cls_003'><span class='cls_003'>GUIDANCE FOR THE MANAGEMENT OF INFECTION IN</span></div>" +
"<div style = 'position:absolute;left:154.58px;top:105.06px' class='cls_003'><span class='cls_003'>PRIMARY CARE WITHIN HERTFORDSHIRE</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:163.50px' class='cls_007'><span class='cls_007'>Ratifying CCG Board Sub-</span></div>" +
"<div style = 'position:absolute;left:278.09px;top:163.50px' class='cls_007'><span class='cls_007'>Hertfordshire Medicines Management</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:176.22px' class='cls_007'><span class='cls_007'>Committee</span></div>" +
"<div style = 'position:absolute;left:278.09px;top:176.22px' class='cls_007'><span class='cls_007'>Committee on behalf of East and North</span></div>" +
"<div style = 'position:absolute;left:278.09px;top:188.82px' class='cls_007'><span class='cls_007'>Herts CCG and Herts Valleys CCG.</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:202.02px' class='cls_007'><span class='cls_007'>Date of Issue(Version 1)</span></div>" +
"<div style = 'position:absolute;left:278.09px;top:201.06px' class='cls_007'><span class='cls_007'>7</span><span class='cls_008'><sup>th</sup></span><span class='cls_007'> July 2015</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:214.14px' class='cls_007'><span class='cls_007'>Date of Issue(1</span><span class='cls_008'><sup>st</sup></span><span class='cls_007'> review)</span></div>" +
"<div style = 'position:absolute;left:278.09px;top:214.14px' class='cls_007'><span class='cls_007'>21</span><span class='cls_008'><sup>st</sup></span><span class='cls_007'> January 2016</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:228.30px' class='cls_007'><span class='cls_007'>Issue Number</span></div>" +
"<div style = 'position:absolute;left:278.09px;top:228.30px' class='cls_007'><span class='cls_007'>2</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:241.38px' class='cls_007'><span class='cls_007'>Date of Review</span></div>" +
"<div style = 'position:absolute;left:278.09px;top:241.38px' class='cls_007'><span class='cls_007'>2 years from date of issue</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:266.34px' class='cls_010'><span class='cls_010'>East and North Herts and Herts Valley’s CCGs are committed to being organisations within</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:277.89px' class='cls_010'><span class='cls_010'>which diversity, equality and human rights are valued.We will not discriminate either directly</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:289.29px' class='cls_010'><span class='cls_010'>or indirectly and will not tolerate harassment or victimisation in relation to gender, marital</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:300.81px' class='cls_010'><span class='cls_010'>status(including civil partnerships), gender reassignment, disability, race, age, sexual</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:312.33px' class='cls_010'><span class='cls_010'>orientation, religion or belief, trade union membership, status as a fixed-term or part - time </ span ></ div >" +
  "<div style = 'position:absolute;left:89.90px;top:323.85px' class='cls_010'><span class='cls_010'>worker, socio-economic status and pregnancy or maternity</span><span class='cls_011'>.</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:346.89px' class='cls_010'><span class='cls_010'>This document was prepared on behalf of East and North Hertfordshire Clinical</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:358.29px' class='cls_010'><span class='cls_010'>Commissioning Group and Herts Valleys Clinical Commissioning Group by the Pharmacy and</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:369.81px' class='cls_010'><span class='cls_010'>Medicines Optimisation Team from East and North Hertfordshire CCG.</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:404.37px' class='cls_010'><span class='cls_010'>This document is available electronically or in a larger font or alternative format on request.</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:443.25px' class='cls_005'><span class='cls_005'>Document History</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:470.75px' class='cls_002'><span class='cls_002'>To replace: Guidance for the Management of Infection in Primary Care within</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:484.55px' class='cls_002'><span class='cls_002'>Hertfordshire November 2014.</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:512.75px' class='cls_005'><span class='cls_005'>Progress</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:512.75px' class='cls_005'><span class='cls_005'>Lead Person & Contact</span></div>" +
"<div style = 'position:absolute;left:414.31px;top:512.75px' class='cls_005'><span class='cls_005'>Date</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:526.55px' class='cls_005'><span class='cls_005'>Number</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:540.83px' class='cls_002'><span class='cls_002'>First Draft</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:540.83px' class='cls_002'><span class='cls_002'>Alison Dossetter(Senior</span></div>" +
"<div style = 'position:absolute;left:414.31px;top:540.83px' class='cls_002'><span class='cls_002'>January 2015</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:554.63px' class='cls_002'><span class='cls_002'>Pharmaceutical Advisor East and</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:568.43px' class='cls_002'><span class='cls_002'>North Herts CCG- 01707</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:582.23px' class='cls_002'><span class='cls_002'>369677)</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:596.51px' class='cls_002'><span class='cls_002'>Second Draft</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:596.51px' class='cls_002'><span class='cls_002'>Alison Dossetter(Senior</span></div>" +
"<div style = 'position:absolute;left:414.31px;top:596.51px' class='cls_002'><span class='cls_002'>April 2015</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:610.31px' class='cls_002'><span class='cls_002'>Pharmaceutical Advisor East and</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:624.11px' class='cls_002'><span class='cls_002'>North Herts CCG- 01707</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:637.91px' class='cls_002'><span class='cls_002'>369677)</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:652.22px' class='cls_002'><span class='cls_002'>Final Draft</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:652.22px' class='cls_002'><span class='cls_002'>Alison Dossetter(Senior</span></div>" +
"<div style = 'position:absolute;left:414.31px;top:652.22px' class='cls_002'><span class='cls_002'>May 2015</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:666.02px' class='cls_002'><span class='cls_002'>Pharmaceutical Advisor East and</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:679.82px' class='cls_002'><span class='cls_002'>North Herts CCG- 01707</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:693.62px' class='cls_002'><span class='cls_002'>369677)</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:707.90px' class='cls_002'><span class='cls_002'>Final Draft(amended)</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:707.90px' class='cls_002'><span class='cls_002'>Alison Dossetter(Senior</span></div>" +
"<div style = 'position:absolute;left:414.31px;top:707.90px' class='cls_002'><span class='cls_002'>June 2015</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:721.70px' class='cls_002'><span class='cls_002'>Pharmaceutical Advisor East and</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:735.50px' class='cls_002'><span class='cls_002'>North Herts CCG- 01707</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:763.22px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function</span></div>" +
"<div style = 'position:absolute;left:498.82px;top:763.34px' class='cls_002'><span class='cls_002'>1</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:777.02px' class='cls_002'><span class='cls_002'>unless otherwise stated.Please refer to latest BNF for further prescribing</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:790.82px' class='cls_002'><span class='cls_002'>information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-297px;top:851px;width:595px;height:841px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background02.jpg' width=595 height=841></div>" +
"<div style = 'position:absolute;left:225.29px;top:88.14px' class='cls_002'><span class='cls_002'>369677)</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:102.42px' class='cls_002'><span class='cls_002'>Final Draft(amended)</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:102.42px' class='cls_002'><span class='cls_002'>Alison Dossetter(Senior</span></div>" +
"<div style = 'position:absolute;left:414.31px;top:102.42px' class='cls_002'><span class='cls_002'>January 2016</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:116.22px' class='cls_002'><span class='cls_002'>Pharmaceutical Advisor East and</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:130.02px' class='cls_002'><span class='cls_002'>North Herts CCG- 01707</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:143.82px' class='cls_002'><span class='cls_002'>369677)</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:158.10px' class='cls_002'><span class='cls_002'>Circulation List</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:158.10px' class='cls_002'><span class='cls_002'>Fiona Simpson - Head of</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:171.90px' class='cls_002'><span class='cls_002'>Infection Control East and North</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:185.70px' class='cls_002'><span class='cls_002'>Herts and Herts Valleys CCGs</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:199.50px' class='cls_002'><span class='cls_002'>Sheilagh Reavey - Director of</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:213.30px' class='cls_002'><span class='cls_002'>Nursing and Quality East and</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:227.10px' class='cls_002'><span class='cls_002'>North Herts CCG</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:240.90px' class='cls_002'><span class='cls_002'>Jan Norman - Director of</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:254.70px' class='cls_002'><span class='cls_002'>Nursing and Quality Herts</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:268.50px' class='cls_002'><span class='cls_002'>Valleys CCG</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:282.33px' class='cls_002'><span class='cls_002'>Pauline Walton - Assistant</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:296.13px' class='cls_002'><span class='cls_002'>Director/Head of Pharmacy and</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:309.93px' class='cls_002'><span class='cls_002'>Medicines Optimisation Team -</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:323.73px' class='cls_002'><span class='cls_002'>East and North Herts CCG</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:337.53px' class='cls_002'><span class='cls_002'>Rasila Shah - Head of Pharmacy</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:351.33px' class='cls_002'><span class='cls_002'>and Medicines Optimisation</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:365.13px' class='cls_002'><span class='cls_002'>Team Herts Valleys CCG</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:378.93px' class='cls_002'><span class='cls_002'>Dr F M Awad-El-Kariem -</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:392.73px' class='cls_002'><span class='cls_002'>consultant microbiologist East</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:406.53px' class='cls_002'><span class='cls_002'>and North Herts Trust</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:420.33px' class='cls_002'><span class='cls_002'>Andrew Hood - Chief Pharmacist</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:434.13px' class='cls_002'><span class='cls_002'>East and North Herts Trust</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:447.93px' class='cls_002'><span class='cls_002'>David Ladenheim - Antimicrobial</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:461.75px' class='cls_002'><span class='cls_002'>pharmacist East and North Herts</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:475.55px' class='cls_002'><span class='cls_002'>Trust</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:489.35px' class='cls_002'><span class='cls_002'>Dr Prema Singh - consultant</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:503.15px' class='cls_002'><span class='cls_002'>microbiologist West Herts Trust</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:516.95px' class='cls_002'><span class='cls_002'>Martin Keble - Chief Pharmacist</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:530.75px' class='cls_002'><span class='cls_002'>West Hertfordshire Trust</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:544.55px' class='cls_002'><span class='cls_002'>Tejal Vaghela - Antimicrobial</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:558.35px' class='cls_002'><span class='cls_002'>pharmacist West Herts Trust</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:572.15px' class='cls_002'><span class='cls_002'>Dr F Bin-Reza - consultant</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:585.95px' class='cls_002'><span class='cls_002'>microbiologist Princess</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:599.75px' class='cls_002'><span class='cls_002'>Alexandra Hospital</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:613.55px' class='cls_002'><span class='cls_002'>Dr Ed Bosonnet - GP Infection</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:627.35px' class='cls_002'><span class='cls_002'>prevention and Control lead East</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:641.15px' class='cls_002'><span class='cls_002'>and North Herts CCG</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:654.98px' class='cls_002'><span class='cls_002'>Dr Pani Sissou - GP Herts</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:668.78px' class='cls_002'><span class='cls_002'>Valleys CCG</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:682.46px' class='cls_002'><span class='cls_002'>Dr Ashish Shah - GP Prescribing</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:696.26px' class='cls_002'><span class='cls_002'>Lead East and North Herts CCG</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:710.06px' class='cls_002'><span class='cls_002'>Gill Goodlad - Local authority,</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:723.86px' class='cls_002'><span class='cls_002'>Public Health</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:737.66px' class='cls_002'><span class='cls_002'>Sarah Mantle - Lead</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:763.22px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function</span></div>" +
"<div style = 'position:absolute;left:498.82px;top:763.34px' class='cls_002'><span class='cls_002'>2</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:777.02px' class='cls_002'><span class='cls_002'>unless otherwise stated.Please refer to latest BNF for further prescribing</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:790.82px' class='cls_002'><span class='cls_002'>information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-297px;top:1702px;width:595px;height:841px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background03.jpg' width=595 height=841></div>" +
"<div style = 'position:absolute;left:225.29px;top:88.14px' class='cls_002'><span class='cls_002'>InfectionPrevention and Control</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:101.94px' class='cls_002'><span class='cls_002'>Nurse HCT</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:115.74px' class='cls_002'><span class='cls_002'>TF Chan - Chief Pharmacist</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:129.54px' class='cls_002'><span class='cls_002'>Barnet and Chase Farm NHS</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:143.34px' class='cls_002'><span class='cls_002'>Trust</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:157.14px' class='cls_002'><span class='cls_002'>Busola Ade-Ojo-Chief</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:170.94px' class='cls_002'><span class='cls_002'>Pharmacist Princess Alexandra</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:184.74px' class='cls_002'><span class='cls_002'>Hospitals NHS Trust</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:198.54px' class='cls_002'><span class='cls_002'>Nisha Patel - Antimicrobial lead</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:212.22px' class='cls_002'><span class='cls_002'>pharmacist Luton & Dunstable</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:226.02px' class='cls_002'><span class='cls_002'>University Hospitals FT</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:239.82px' class='cls_002'><span class='cls_002'>Simon Wan - Chief Pharmacist</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:253.62px' class='cls_002'><span class='cls_002'>HCT</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:267.42px' class='cls_002'><span class='cls_002'>Janet Howell - Head of</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:281.25px' class='cls_002'><span class='cls_002'>Medicines Management</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:295.05px' class='cls_002'><span class='cls_002'>Hertfordshire Partnership NHS</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:308.85px' class='cls_002'><span class='cls_002'>Trust</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:322.65px' class='cls_002'><span class='cls_002'>Rita Cusumano - Head of</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:336.45px' class='cls_002'><span class='cls_002'>Integrated Clinical Governance</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:350.25px' class='cls_002'><span class='cls_002'>Herts Urgent Care</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:364.05px' class='cls_002'><span class='cls_002'>All pharmacists working for East</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:377.85px' class='cls_002'><span class='cls_002'>and North Herts CCG for onward</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:391.65px' class='cls_002'><span class='cls_002'>distribution to locality prescribing</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:405.45px' class='cls_002'><span class='cls_002'>leads</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:419.25px' class='cls_002'><span class='cls_002'>All pharmacists working for Herts</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:433.05px' class='cls_002'><span class='cls_002'>Valleys CCG for onward</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:446.85px' class='cls_002'><span class='cls_002'>distribution to locality prescribing</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:460.67px' class='cls_002'><span class='cls_002'>leads</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:474.47px' class='cls_002'><span class='cls_002'>All locality prescribing leads for</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:488.27px' class='cls_002'><span class='cls_002'>onward distribution within GP</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:502.07px' class='cls_002'><span class='cls_002'>practices to all prescribers</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:530.15px' class='cls_002'><span class='cls_002'>Policy Precedents</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:530.15px' class='cls_002'><span class='cls_002'>Guidance for the management of</span></div>" +
"<div style = 'position:absolute;left:414.31px;top:530.15px' class='cls_002'><span class='cls_002'>November 2014</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:543.95px' class='cls_002'><span class='cls_002'>infection in primary care within</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:557.75px' class='cls_002'><span class='cls_002'>Hertfordshire</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:572.15px' class='cls_002'><span class='cls_002'>Ratified by HMMC</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:570.59px' class='cls_002'><span class='cls_002'>7</span><span class='cls_012'><sup>th</sup></span><span class='cls_002'> July 2015</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:586.43px' class='cls_002'><span class='cls_002'>Review Date</span></div>" +
"<div style = 'position:absolute;left:225.29px;top:586.43px' class='cls_002'><span class='cls_002'>2 years from date of issue</span></div>" +
"<div style = 'position:absolute;left:150.98px;top:651.50px' class='cls_009'><span class='cls_009'>Produced by the Pharmacy and Medicines Optimisation Team</span></div>" +
"<div style = 'position:absolute;left:154.58px;top:656.90px' class='cls_009'><span class='cls_009'>East and North Hertfordshire Clinical Commissioning Group</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:763.22px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function</span></div>" +
"<div style = 'position:absolute;left:498.82px;top:763.34px' class='cls_002'><span class='cls_002'>3</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:777.02px' class='cls_002'><span class='cls_002'>unless otherwise stated.Please refer to latest BNF for further prescribing</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:790.82px' class='cls_002'><span class='cls_002'>information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-297px;top:2553px;width:595px;height:841px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background04.jpg' width=595 height=841></div>" +
"<div style = 'position:absolute;left:98.54px;top:102.06px' class='cls_033'><span class='cls_033'>GUIDANCE FOR THE MANAGEMENT OF INFECTION</span></div>" +
"<div style = 'position:absolute;left:125.90px;top:139.14px' class='cls_034'><span class='cls_034'>Contents</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:180.54px' class='cls_002'><span class='cls_002'>1. </span><span class='cls_014'> </span><span class='cls_035'>Purpose</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:180.54px' class='cls_002'><span class='cls_002'>5</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:194.34px' class='cls_002'><span class='cls_002'>2. </span><span class='cls_014'> </span><span class='cls_035'>Disclaimer</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:194.34px' class='cls_002'><span class='cls_002'>5</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:208.14px' class='cls_002'><span class='cls_002'>3. </span><span class='cls_014'> </span><span class='cls_035'>Changes from November 2014</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:208.14px' class='cls_002'><span class='cls_002'>5</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:221.94px' class='cls_002'><span class='cls_002'>4. </span><span class='cls_014'> </span><span class='cls_035'>Aims</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:221.94px' class='cls_002'><span class='cls_002'>10</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:235.74px' class='cls_002'><span class='cls_002'>5. </span><span class='cls_014'> </span><span class='cls_035'>Principles of treatment</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:235.74px' class='cls_002'><span class='cls_002'>10</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:249.54px' class='cls_002'><span class='cls_002'>6. </span><span class='cls_014'> </span><span class='cls_035'>Educational resources</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:249.54px' class='cls_002'><span class='cls_002'>11</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:263.22px' class='cls_002'><span class='cls_002'>7. </span><span class='cls_015'> </span><span class='cls_036'>Clostridium difficile</span><span class='cls_035'>infection</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:263.22px' class='cls_002'><span class='cls_002'>11</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:277.17px' class='cls_002'><span class='cls_002'>8. </span><span class='cls_014'> </span><span class='cls_035'>Pneumonia and C-reactive protein(CRP) test</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:277.17px' class='cls_002'><span class='cls_002'>12</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:290.97px' class='cls_002'><span class='cls_002'>9. </span><span class='cls_014'> </span><span class='cls_035'>Restricted antibiotics</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:290.97px' class='cls_002'><span class='cls_002'>13</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:304.77px' class='cls_002'><span class='cls_002'>10. </span><span class='cls_035'>Schools and other childcare settings</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:304.77px' class='cls_002'><span class='cls_002'>14</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:318.57px' class='cls_002'><span class='cls_002'>11. </span><span class='cls_035'>Specific drug warnings</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:318.57px' class='cls_002'><span class='cls_002'>14</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:332.37px' class='cls_002'><span class='cls_002'>a. </span><span class='cls_014'> </span><span class='cls_035'>Co-amoxiclav</span><span class='cls_016'>♣</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:332.37px' class='cls_002'><span class='cls_002'>14</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:346.17px' class='cls_002'><span class='cls_002'>b. </span><span class='cls_014'> </span><span class='cls_035'>Erythromycin</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:346.17px' class='cls_002'><span class='cls_002'>14</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:359.97px' class='cls_002'><span class='cls_002'>c. </span><span class='cls_014'> </span><span class='cls_035'>Flucloxacillin</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:359.97px' class='cls_002'><span class='cls_002'>14</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:373.77px' class='cls_002'><span class='cls_002'>d. </span><span class='cls_014'> </span><span class='cls_035'>Fosfomycin</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:373.77px' class='cls_002'><span class='cls_002'>14</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:387.57px' class='cls_002'><span class='cls_002'>e. </span><span class='cls_014'> </span><span class='cls_035'>Itraconazole</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:387.57px' class='cls_002'><span class='cls_002'>15</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:401.37px' class='cls_002'><span class='cls_002'>f. </span><span class='cls_014'>  </span><span class='cls_035'>Nitrofurantoin</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:401.37px' class='cls_002'><span class='cls_002'>15</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:415.17px' class='cls_002'><span class='cls_002'>g. </span><span class='cls_014'> </span><span class='cls_035'>Pivmecillinam</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:415.17px' class='cls_002'><span class='cls_002'>15</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:428.97px' class='cls_002'><span class='cls_002'>h. </span><span class='cls_014'> </span><span class='cls_035'>Quinolones</span><span class='cls_016'>♣</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:428.97px' class='cls_002'><span class='cls_002'>15</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:442.77px' class='cls_002'><span class='cls_002'>i.</span></div>" +
"<div style = 'position:absolute;left:161.90px;top:442.77px' class='cls_035'><span class='cls_035'>Trimethoprim</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:442.77px' class='cls_002'><span class='cls_002'>15</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:456.57px' class='cls_002'><span class='cls_002'>12. </span><span class='cls_035'>Reference sources</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:456.57px' class='cls_002'><span class='cls_002'>16</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:470.39px' class='cls_002'><span class='cls_002'>13. </span><span class='cls_035'>Acknowledgements</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:470.39px' class='cls_002'><span class='cls_002'>17</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:484.19px' class='cls_002'><span class='cls_002'>14. </span><span class='cls_035'>Comments</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:484.19px' class='cls_002'><span class='cls_002'>17</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:497.99px' class='cls_002'><span class='cls_002'>15. </span><span class='cls_035'>Clinical Guidelines</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:497.99px' class='cls_002'><span class='cls_002'>18</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:511.79px' class='cls_002'><span class='cls_002'>a. </span><span class='cls_014'> </span><span class='cls_035'>Upper respiratory tract infections</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:511.79px' class='cls_002'><span class='cls_002'>18</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:525.59px' class='cls_002'><span class='cls_002'>b. </span><span class='cls_014'> </span><span class='cls_035'>Lower respiratory tract infections</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:525.59px' class='cls_002'><span class='cls_002'>20</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:539.39px' class='cls_002'><span class='cls_002'>c. </span><span class='cls_014'> </span><span class='cls_035'>Meningitis</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:539.39px' class='cls_002'><span class='cls_002'>22</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:553.19px' class='cls_002'><span class='cls_002'>d. </span><span class='cls_014'> </span><span class='cls_035'>Urinary tract infections</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:553.19px' class='cls_002'><span class='cls_002'>22</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:566.99px' class='cls_002'><span class='cls_002'>e. </span><span class='cls_014'> </span><span class='cls_035'>Gastro-intestinal tract infections</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:566.99px' class='cls_002'><span class='cls_002'>27</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:580.79px' class='cls_002'><span class='cls_002'>f. </span><span class='cls_014'>  </span><span class='cls_035'>Genital tract infections</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:580.79px' class='cls_002'><span class='cls_002'>30</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:594.59px' class='cls_002'><span class='cls_002'>g. </span><span class='cls_014'> </span><span class='cls_035'>Skin</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:594.59px' class='cls_002'><span class='cls_002'>32</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:608.39px' class='cls_002'><span class='cls_002'>h. </span><span class='cls_014'> </span><span class='cls_035'>Viral</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:608.39px' class='cls_002'><span class='cls_002'>37</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:622.19px' class='cls_002'><span class='cls_002'>i.</span></div>" +
"<div style = 'position:absolute;left:161.90px;top:622.19px' class='cls_035'><span class='cls_035'>Dental</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:622.19px' class='cls_002'><span class='cls_002'>38</span></div>" +
"<div style = 'position:absolute;left:107.90px;top:635.99px' class='cls_002'><span class='cls_002'>16. </span><span class='cls_035'>Treatment Algorithms - Management</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:635.99px' class='cls_002'><span class='cls_002'>39</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:649.82px' class='cls_002'><span class='cls_002'>a. </span><span class='cls_014'> </span><span class='cls_035'>Suspected UTI in women(not pregnant)</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:649.82px' class='cls_002'><span class='cls_002'>39</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:663.62px' class='cls_002'><span class='cls_002'>b. </span><span class='cls_014'> </span><span class='cls_035'>Suspected UTI in men</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:663.62px' class='cls_002'><span class='cls_002'>40</span></div>" +
"<div style = 'position:absolute;left:143.90px;top:677.42px' class='cls_002'><span class='cls_002'>c. </span><span class='cls_014'> </span><span class='cls_035'>Suspected UTI in older people(over 65 years)</span></div>" +
"<div style = 'position:absolute;left:449.95px;top:677.42px' class='cls_002'><span class='cls_002'>41</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:763.22px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function</span></div>" +
"<div style = 'position:absolute;left:498.82px;top:763.34px' class='cls_002'><span class='cls_002'>4</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:777.02px' class='cls_002'><span class='cls_002'>unless otherwise stated.Please refer to latest BNF for further prescribing</span></div>" +
"<div style = 'position:absolute;left:89.90px;top:790.82px' class='cls_002'><span class='cls_002'>information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:3404px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background05.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:72.00px;top:88.62px' class='cls_034'><span class='cls_034'>Purpose</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:116.22px' class='cls_002'><span class='cls_002'>To support the appropriate prescribing of antibiotics in primary care.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:143.82px' class='cls_034'><span class='cls_034'>Disclaimer</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:171.42px' class='cls_002'><span class='cls_002'>Whilst every effort has been made to ensure the accuracy of this guideline, the authors cannot accept any responsibility for any</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:185.22px' class='cls_002'><span class='cls_002'>errors or omissions.The prescriber should be aware of any side effects, drug interactions or patient specific contra-indications as</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:199.05px' class='cls_002'><span class='cls_002'>detailed in the current British National Formulary or the Summary of Product Characteristics.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:226.65px' class='cls_034'><span class='cls_034'>Changes from November 2014</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:255.09px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:255.09px' class='cls_005'><span class='cls_005'>Addition of choice of antibiotic for the following indications:</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:268.77px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_014'>  </span><span class='cls_035'>Otitis Externa(acute)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:282.57px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_014'>  </span><span class='cls_035'>Bronchiectasis</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:296.37px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_014'>  </span><span class='cls_035'>UTI in women - no visible haematuria, not pregnant or catheterised</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:310.17px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_014'>  </span><span class='cls_035'>UTI in women - visible or non visible haematuria, not pregnant</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:323.99px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_014'>  </span><span class='cls_035'>Asymptomatic bacteriuria in pregnancy</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:337.79px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_014'>  </span><span class='cls_035'>Catheter in situ</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:351.59px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_014'>  </span><span class='cls_035'>UTI with catheter</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:365.39px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_014'>  </span><span class='cls_035'>Pilonidal sinus disease(discharging)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:379.19px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_014'>  </span><span class='cls_035'>Post-operative wound infection</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:407.63px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:407.63px' class='cls_005'><span class='cls_005'>Revised or new drug choices for:</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:435.71px' class='cls_005'><span class='cls_005'>Condition</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:435.71px' class='cls_005'><span class='cls_005'>Changed from(November 2014)</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:435.71px' class='cls_005'><span class='cls_005'>Changed to(April 2015)</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:449.99px' class='cls_014'><span class='cls_014'>Otitis media(acute)</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:448.43px' class='cls_002'><span class='cls_002'>Azithromycin 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:449.99px' class='cls_002'><span class='cls_002'>Azithromycin removed from guidelines</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:464.30px' class='cls_014'><span class='cls_014'>Sinusitis(acute)</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:462.74px' class='cls_002'><span class='cls_002'>Amoxicillin 1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:462.74px' class='cls_002'><span class='cls_002'>Amoxicillin 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:478.70px' class='cls_014'><span class='cls_014'>Bronchitis(acute)</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:477.14px' class='cls_002'><span class='cls_002'>Doxycycline 1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:477.14px' class='cls_002'><span class='cls_002'>Doxycycline 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice and</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:763.30px;top:531.14px' class='cls_002'><span class='cls_002'>5</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:4009px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background06.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:538.15px;top:87.54px' class='cls_002'><span class='cls_002'>clarithromycin added as a further 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:102.90px' class='cls_002'><span class='cls_002'>choice in penicillin allergy</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:117.18px' class='cls_035'><span class='cls_035'>Acute Exacerbation of COPD</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:115.62px' class='cls_002'><span class='cls_002'>Clarithromycin added as further 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:130.98px' class='cls_002'><span class='cls_002'>choice</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:145.26px' class='cls_035'><span class='cls_035'>Community acquired pneumonia</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:143.70px' class='cls_002'><span class='cls_002'>Clarithromycin and doxycycline 1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:143.70px' class='cls_002'><span class='cls_002'>Clarithromycin and doxycycline 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:159.06px' class='cls_002'><span class='cls_002'>choices</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:159.06px' class='cls_002'><span class='cls_002'>choices</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:173.34px' class='cls_014'><span class='cls_014'>Meningitis</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:171.78px' class='cls_002'><span class='cls_002'>Cefotaxime 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:173.34px' class='cls_002'><span class='cls_002'>Cefotaxime removed from guidelines</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:187.74px' class='cls_035'><span class='cls_035'>UTI in men</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:186.18px' class='cls_002'><span class='cls_002'>Nitrofurantoin 1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:186.18px' class='cls_002'><span class='cls_002'>Nitrofurantoin 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice and</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:200.01px' class='cls_002'><span class='cls_002'>pivmecillinam added as further 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:215.25px' class='cls_002'><span class='cls_002'>choice</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:229.65px' class='cls_035'><span class='cls_035'>UTI - recurrent</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:228.09px' class='cls_002'><span class='cls_002'>Nitrofurantoin added as further 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:243.45px' class='cls_002'><span class='cls_002'>choice</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:257.73px' class='cls_035'><span class='cls_035'>Pyelonephritis(acute)</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:256.17px' class='cls_002'><span class='cls_002'>Co-amoxiclav 1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:256.17px' class='cls_002'><span class='cls_002'>Co-amoxiclav 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice and cefalexin</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:269.97px' class='cls_002'><span class='cls_002'>added as a 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line option for pregnant</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:285.33px' class='cls_002'><span class='cls_002'>women</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:299.49px' class='cls_036'><span class='cls_036'>Clostridium difficile</span><span class='cls_035'> infection(CDI)</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:298.05px' class='cls_002'><span class='cls_002'>Fidaxomicin added as a further 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:313.41px' class='cls_002'><span class='cls_002'>choice</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:327.71px' class='cls_014'><span class='cls_014'>CDI recurrence</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:326.15px' class='cls_002'><span class='cls_002'>Fidaxomicin added as 1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:341.87px' class='cls_036'><span class='cls_036'>Helicobacter pylori</span><span class='cls_035'> eradication</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:340.43px' class='cls_002'><span class='cls_002'>Metronidazole added as an option for 1</span><span class='cls_012'><sup>st</sup></span></div>" +
"<div style = 'position:absolute;left:538.15px;top:355.79px' class='cls_002'><span class='cls_002'>line choice in combination with amoxicillin</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:369.59px' class='cls_002'><span class='cls_002'>and clarithromycin added as a further</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:381.83px' class='cls_002'><span class='cls_002'>option for 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:397.67px' class='cls_014'><span class='cls_014'>Threadworm</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:396.11px' class='cls_002'><span class='cls_002'>Piperazine/senna 1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:397.67px' class='cls_002'><span class='cls_002'>Piperazine/senna removed from guidelines</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:412.07px' class='cls_035'><span class='cls_035'>Vaginal candidiasis in pregnancy</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:410.51px' class='cls_002'><span class='cls_002'>Miconazole 2% cream added as a 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:425.87px' class='cls_002'><span class='cls_002'>choice</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:440.15px' class='cls_014'><span class='cls_014'>Bacterial vaginosis</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:438.59px' class='cls_002'><span class='cls_002'>Metronidazole gel 1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:438.59px' class='cls_002'><span class='cls_002'>Metronidazole gel 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:454.43px' class='cls_035'><span class='cls_035'>Epididymo-orchitis</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:452.87px' class='cls_002'><span class='cls_002'>Co-amoxiclav 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice for over 35</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:454.43px' class='cls_002'><span class='cls_002'>Co-amoxiclav removed from guidelines and</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:468.26px' class='cls_002'><span class='cls_002'>years</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:466.70px' class='cls_002'><span class='cls_002'>ofloxacin added as a further 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:482.06px' class='cls_002'><span class='cls_002'>for over 35 years</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:763.30px;top:531.14px' class='cls_002'><span class='cls_002'>6</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:4614px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background07.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:105.74px;top:89.10px' class='cls_035'><span class='cls_035'>Pelvic inflammatory disease</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:87.54px' class='cls_002'><span class='cls_002'>Metronidazole plus ofloxacin 1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:89.10px' class='cls_002'><span class='cls_002'>Ceftriaxone plus metronidazole plus</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:102.90px' class='cls_002'><span class='cls_002'>choice and Ceftriaxone plus</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:101.34px' class='cls_002'><span class='cls_002'>doxycycline 1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line choice and</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:115.14px' class='cls_002'><span class='cls_002'>metronidazole plus doxycycline 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line</span></div>" +
"<div style = 'position:absolute;left:538.15px;top:115.14px' class='cls_002'><span class='cls_002'>metronidazole plus ofloxacin 2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line choice</span></div>" +
"<div style = 'position:absolute;left:304.25px;top:130.50px' class='cls_002'><span class='cls_002'>choice</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:173.22px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:173.22px' class='cls_005'><span class='cls_005'>Revised dosage or frequency or duration of treatment for:</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:201.33px' class='cls_005'><span class='cls_005'>Condition</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:201.33px' class='cls_005'><span class='cls_005'>Changed from(November 2014)</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:201.33px' class='cls_005'><span class='cls_005'>Changed to(April 2015)</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:215.61px' class='cls_014'><span class='cls_014'>Community acquired pneumonia</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:215.61px' class='cls_002'><span class='cls_002'>Course length 7 days for CRB65 = 0</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:215.61px' class='cls_002'><span class='cls_002'>Course length 5 days for CRB65 = 0</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:229.89px' class='cls_035'><span class='cls_035'>Community acquired pneumonia</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:229.89px' class='cls_002'><span class='cls_002'>Course length 10 days for CRB65 = 1</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:229.89px' class='cls_002'><span class='cls_002'>Course length 7 to 10 days for CRB65 =</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:243.69px' class='cls_002'><span class='cls_002'>1</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:257.97px' class='cls_014'><span class='cls_014'>UTI in pregnancy</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:257.97px' class='cls_002'><span class='cls_002'>Cefalexin 250mg QDS</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:257.97px' class='cls_002'><span class='cls_002'>Cefalexin 500mg BD</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:272.25px' class='cls_015'><span class='cls_015'>Clostridium difficile</span><span class='cls_014'> infection(CDI)</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:272.37px' class='cls_002'><span class='cls_002'>Metronidazole 400mg</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:272.37px' class='cls_002'><span class='cls_002'>Metronidazole 400mg to 500mg</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:286.53px' class='cls_036'><span class='cls_036'>Helicobacter pylori</span><span class='cls_035'> eradication</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:286.65px' class='cls_002'><span class='cls_002'>Tripotassium dicitratobismuthate 120mg</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:286.65px' class='cls_002'><span class='cls_002'>Tripotassium dicitratobismuthate 240mg</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:300.45px' class='cls_002'><span class='cls_002'>QDS</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:300.45px' class='cls_002'><span class='cls_002'>BD</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:314.73px' class='cls_014'><span class='cls_014'>Vaginal candidiasis in pregnancy</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:314.73px' class='cls_002'><span class='cls_002'>Course length 6 nights</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:314.73px' class='cls_002'><span class='cls_002'>Course length 7 days</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:329.03px' class='cls_035'><span class='cls_035'>Bacterial vaginosis</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:329.03px' class='cls_002'><span class='cls_002'>Course length for stat dose of</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:329.03px' class='cls_002'><span class='cls_002'>Course length for stat dose of</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:342.83px' class='cls_002'><span class='cls_002'>metronidazole 7 days</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:342.83px' class='cls_002'><span class='cls_002'>metronidazole 5 to 7 days</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:357.11px' class='cls_035'><span class='cls_035'>Epididymo-orchitis</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:357.11px' class='cls_002'><span class='cls_002'>Course length for over 35s 10 days</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:357.11px' class='cls_002'><span class='cls_002'>Course length for over 35s 10 to 14</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:370.91px' class='cls_002'><span class='cls_002'>days</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:385.07px' class='cls_015'><span class='cls_015'>Trichomonas vaginalis</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:385.19px' class='cls_002'><span class='cls_002'>Metronidazole 400mg</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:385.19px' class='cls_002'><span class='cls_002'>Metronidazole 400mg to 500mg</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:399.47px' class='cls_014'><span class='cls_014'>Acne(moderate or severe)</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:399.47px' class='cls_002'><span class='cls_002'>Course length 4 to 6 months</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:399.47px' class='cls_002'><span class='cls_002'>Course length up to 6 months</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:413.87px' class='cls_014'><span class='cls_014'>Bites(animal and human)</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:413.87px' class='cls_002'><span class='cls_002'>Metronidazole 400mg</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:413.87px' class='cls_002'><span class='cls_002'>Metronidazole 200mg to 400mg</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:428.15px' class='cls_035'><span class='cls_035'>Dermatophyte infection of the finger or</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:428.15px' class='cls_002'><span class='cls_002'>Amorolfine course length for toes 12</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:428.15px' class='cls_002'><span class='cls_002'>Amorolfine course length for toes 9 to</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:441.95px' class='cls_014'><span class='cls_014'>toe nail</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:441.95px' class='cls_002'><span class='cls_002'>months</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:441.95px' class='cls_002'><span class='cls_002'>12 months</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:456.26px' class='cls_014'><span class='cls_014'>Shingles</span></div>" +
"<div style = 'position:absolute;left:330.77px;top:456.26px' class='cls_002'><span class='cls_002'>Famciclovir 250mg</span></div>" +
"<div style = 'position:absolute;left:555.79px;top:456.26px' class='cls_002'><span class='cls_002'>Famciclovir 500mg</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:763.30px;top:531.14px' class='cls_002'><span class='cls_002'>7</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:5219px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background08.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:90.00px;top:89.46px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:89.46px' class='cls_005'><span class='cls_005'>Revision / addition of comments or advice:</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:103.14px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:103.14px' class='cls_002'><span class='cls_002'>Principles of treatment</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:116.94px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:116.94px' class='cls_002'><span class='cls_002'>Educational resources - addition of link to patient information leaflet</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:130.62px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:130.62px' class='cls_019'><span class='cls_019'>Clostridium difficile</span><span class='cls_002'>Infection</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:144.54px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:144.54px' class='cls_002'><span class='cls_002'>Pneumonia and C-reactive protein(CRP) test</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:158.34px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:158.34px' class='cls_002'><span class='cls_002'>Guidance on infection control in schools and other childcare settings</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:172.14px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:172.14px' class='cls_002'><span class='cls_002'>Fosfomycin specific drug warning</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:185.94px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:185.94px' class='cls_002'><span class='cls_002'>Nitrofurantoin specific drug warning</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:199.77px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:199.77px' class='cls_002'><span class='cls_002'>Pivmecillinam specific drug warning</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:213.57px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:213.57px' class='cls_002'><span class='cls_002'>Upper Respiratory Tract Infections</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:227.37px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:227.37px' class='cls_002'><span class='cls_002'>Pharyngitis / Sore throat / Tonsillitis</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:241.17px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:241.17px' class='cls_002'><span class='cls_002'>Otitis media(acute)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:254.97px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:254.97px' class='cls_002'><span class='cls_002'>Sinusitis(acute)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:268.77px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:268.77px' class='cls_002'><span class='cls_002'>Lower Respiratory Tract Infections(LRTIs)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:282.57px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:282.57px' class='cls_002'><span class='cls_002'>Bronchitis(acute)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:296.37px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:296.37px' class='cls_002'><span class='cls_002'>Acute Exacerbation of COPD</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:310.17px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:310.17px' class='cls_002'><span class='cls_002'>Community acquired pneumonia</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:323.99px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:323.99px' class='cls_002'><span class='cls_002'>Meningitis</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:337.79px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:337.79px' class='cls_002'><span class='cls_002'>Urine dipstick testing</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:351.59px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:351.59px' class='cls_002'><span class='cls_002'>UTI in pregnancy</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:365.39px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:365.39px' class='cls_002'><span class='cls_002'>UTI in children</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:379.19px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:379.19px' class='cls_002'><span class='cls_002'>UTI recurrent</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:392.99px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:392.99px' class='cls_002'><span class='cls_002'>Pyelonephritis(acute)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:406.79px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:406.79px' class='cls_002'><span class='cls_002'>Prostatitis(acute)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:420.59px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:420.59px' class='cls_002'><span class='cls_002'>Gastroenteritis</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:434.27px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:434.27px' class='cls_019'><span class='cls_019'>Clostridium difficile</span><span class='cls_002'>infection(CDI)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:448.19px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:448.19px' class='cls_002'><span class='cls_002'>CDI recurrence</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:461.90px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:461.90px' class='cls_019'><span class='cls_019'>Helicobacter pylori</span><span class='cls_002'>eradication</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:475.82px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:475.82px' class='cls_002'><span class='cls_002'>Threadworm</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:489.62px' class='cls_018'><span class='cls_018'>o</span></div>" +
"<div style = 'position:absolute;left:144.02px;top:489.62px' class='cls_002'><span class='cls_002'>Diverticulitis(acute)</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:763.30px;top:531.14px' class='cls_002'><span class='cls_002'>8</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:5824px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background09.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:126.02px;top:88.62px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Vaginal candidiasis</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:102.42px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Vaginal candidiasis in pregnancy</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:116.22px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Bacterial vaginosis</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:129.90px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_019'>  Chlamydia trachomatis</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:143.82px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Epididymo-orchitis</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:157.50px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'> </span><span class='cls_019'>  Trichomonas vaginalis</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:171.42px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Pelvic inflammatory disease</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:185.22px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Acne(moderate or severe)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:199.05px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Bites(animal and human)</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:212.85px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Dermatophyte infection of the nail</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:226.65px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Dermatophyte infection of the skin</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:240.45px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Eczema</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:254.25px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Leg ulcers</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:268.05px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   PVL</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:281.85px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Shingles</span></div>" +
"<div style = 'position:absolute;left:126.02px;top:295.65px' class='cls_018'><span class='cls_018'>o</span><span class='cls_002'>   Treatment algorithms for management of UTI</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:323.27px' class='cls_034'><span class='cls_034'>Changes from April 2015</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:351.71px' class='cls_017'><span class='cls_017'></span><span class='cls_002'> </span><span class='cls_005'>  </span><span class='cls_034'>Revised or new drug choices for:</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:379.67px' class='cls_005'><span class='cls_005'>Condition</span></div>" +
"<div style = 'position:absolute;left:332.21px;top:379.67px' class='cls_005'><span class='cls_005'>Changed from(April 2015)</span></div>" +
"<div style = 'position:absolute;left:556.51px;top:379.67px' class='cls_005'><span class='cls_005'>Changed to(January 2016)</span></div>" +
"<div style = 'position:absolute;left:105.74px;top:393.95px' class='cls_036'><span class='cls_036'>Helicobacter pylori</span><span class='cls_035'> eradication</span></div>" +
"<div style = 'position:absolute;left:332.21px;top:394.07px' class='cls_002'><span class='cls_002'>PPI BD plus tripotassium</span></div>" +
"<div style = 'position:absolute;left:556.51px;top:394.07px' class='cls_002'><span class='cls_002'>PPI BD plus 2 unused antibiotics:</span></div>" +
"<div style = 'position:absolute;left:332.21px;top:407.87px' class='cls_002'><span class='cls_002'>dicitratobismuthate 240mg BD plus 2</span></div>" +
"<div style = 'position:absolute;left:556.51px;top:407.87px' class='cls_002'><span class='cls_002'>amoxicillin 1G BD, metronidazole</span></div>" +
"<div style = 'position:absolute;left:332.21px;top:421.67px' class='cls_002'><span class='cls_002'>unused antibiotics: amoxicillin 1G BD,</span></div>" +
"<div style = 'position:absolute;left:556.51px;top:421.67px' class='cls_002'><span class='cls_002'>400mg BD, tetracycline 500mg QDS,</span></div>" +
"<div style = 'position:absolute;left:332.21px;top:435.47px' class='cls_002'><span class='cls_002'>metronidazole 400mg BD, tetracycline</span></div>" +
"<div style = 'position:absolute;left:556.51px;top:435.47px' class='cls_002'><span class='cls_002'>clarithromycin 500mg BD, levofloxacin</span></div>" +
"<div style = 'position:absolute;left:332.21px;top:449.27px' class='cls_002'><span class='cls_002'>500mg QDS, clarithromycin 500mg BD</span></div>" +
"<div style = 'position:absolute;left:556.51px;top:449.27px' class='cls_002'><span class='cls_002'>250mg BD</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:763.30px;top:531.14px' class='cls_002'><span class='cls_002'>9</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:6429px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background10.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:72.00px;top:88.62px' class='cls_034'><span class='cls_034'>Aims</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:116.22px' class='cls_002'><span class='cls_002'>The aims of these guidelines, in line with evidence based national guidelines and primary care priorities are to:</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:144.66px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   Promote the safe, effective and economic use of antibiotics.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:159.06px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   Manage the prescribing of antibiotics thus reducing the incidence of antibiotic associated infections such as </span><span class='cls_019'>Clostridium</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:172.86px' class='cls_019'><span class='cls_019'>difficile</span><span class='cls_002'>infection(CDI) and MRSA infection.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:187.62px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   Minimise the emergence of bacterial resistance to antibiotics within the community.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:202.29px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   Assist prescribers in selecting an appropriate antibiotic for commonly encountered infections.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:229.89px' class='cls_034'><span class='cls_034'>Principles of treatment</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:258.33px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:258.33px' class='cls_002'><span class='cls_002'>This guidance is based on the best available evidence but professional judgement should always be used and patients</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:272.01px' class='cls_002'><span class='cls_002'>should be involved in the decision making process.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:286.65px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:286.65px' class='cls_002'><span class='cls_002'>Choices of antibiotic are based on clinical evidence and not on cost as the aim is to reduce the incidence of healthcare</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:300.45px' class='cls_002'><span class='cls_002'>associated infections.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:315.09px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:315.09px' class='cls_002'><span class='cls_002'>Antibiotics should be initiated as soon as possible in severe infection.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:329.75px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:329.75px' class='cls_002'><span class='cls_002'>Prescribing of antibiotics should only occur where consideration has been given to the origin of infection, there is a clinical</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:343.43px' class='cls_002'><span class='cls_002'>need and the presence of viral infection such as sore throat, coughs and colds, viral conjunctivitis has been excluded.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:358.07px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:358.07px' class='cls_005'><span class='cls_005'>Antibiotics should not be prescribed during a telephone consultation apart from in exceptional circumstances</span><span class='cls_002'>.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:372.71px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:372.71px' class='cls_002'><span class='cls_002'>Consider the use of a delayed prescription for infections such as simple urinary tract infections, acute sore throat, acute</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:386.51px' class='cls_002'><span class='cls_002'>cough, acute sinusitis, common cold.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:401.15px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:401.15px' class='cls_002'><span class='cls_002'>Where an antibiotic is indicated, the agent chosen should be the narrowest spectrum for the identified condition i.e.avoid</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:414.95px' class='cls_002'><span class='cls_002'>broad spectrum antibiotics such as co-amoxiclav</span><span class='cls_016'>♣</span><span class='cls_002'>, cephalosporins</span><span class='cls_016'>♣</span><span class='cls_002'> and quinolones</span><span class='cls_016'>♣</span><span class='cls_002'>.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:429.59px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:429.59px' class='cls_002'><span class='cls_002'>Always prescribe for the shortest duration(using broad spectrum antibiotics for long periods can promote resistance).</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:444.11px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:444.11px' class='cls_002'><span class='cls_002'>Always prescribe generically.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:458.78px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:458.78px' class='cls_002'><span class='cls_002'>Avoid topical antibiotics unless indicated as they can promote resistance.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:473.42px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:473.42px' class='cls_002'><span class='cls_002'>Always check for allergy before prescribing an antibiotic.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>10</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:7034px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background11.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:90.00px;top:89.46px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   In</span><span class='cls_005'>pregnancy</span><span class='cls_002'> </span><span class='cls_005'>AVOID</span><span class='cls_002'> prescribing tetracyclines, quinolones</span><span class='cls_016'>♣</span><span class='cls_002'>, and high dose metronidazole.If trimethoprim is prescribed in</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:103.14px' class='cls_002'><span class='cls_002'>the first trimester, supplementation with folic acid 5mg is recommended and trimethoprim should not be prescribed to women</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:116.94px' class='cls_002'><span class='cls_002'>who are folate deficient, taking a folate antagonist or have taken trimethoprim within the last year.Short term use of</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:129.18px' class='cls_002'><span class='cls_002'>nitrofurantoin(avoid in 3</span><span class='cls_012'><sup>rd</sup></span><span class='cls_002'> trimester as there is a theoretical risk of neonatal haemolysis) is not expected to cause foetal</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:144.54px' class='cls_002'><span class='cls_002'>problems.The manufacturer of clarithromycin advises against its use in pregnancy, particularly in the first trimester, unless</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:158.34px' class='cls_002'><span class='cls_002'>the potential benefit outweighs the risk.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:172.98px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   For recurrent or resistant infection, please contact your local microbiologist for advice.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:200.61px' class='cls_034'><span class='cls_034'>Educational Resources</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:229.05px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   A leaflet entitled ‘Treating your Infection’ has been produced by the Royal College of General Practitioners in conjunction</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:242.85px' class='cls_002'><span class='cls_002'>with numerous other national bodies.It gives patients useful information on the duration of upper respiratory tract infections,</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:256.65px' class='cls_002'><span class='cls_002'>what patients can do to ease symptoms and also safety nets for those patients whose condition deteriorates.It is available at</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:270.45px' class='cls_002'><span class='cls_002'>the following link in a variety of languages: </span><A HREF = 'http://www.rcgp.org.uk/clinical-and-research/target-antibiotics-toolkit/patient-information-leaflets.aspx' > http://www.rcgp.org.uk/clinical-and-research/target-antibiotics-toolkit/patient-</A> </span></div>" +
"<div style = 'position:absolute;left:108.02px;top:284.25px' class='cls_035'><span class='cls_035'> </span><A HREF = 'http://www.rcgp.org.uk/clinical-and-research/target-antibiotics-toolkit/patient-information-leaflets.aspx' > information - leaflets.aspx </ A > </ div >" +
"<div style='position:absolute;left:90.00px;top:298.89px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   The Royal College of General Practitioners have published a ‘TARGET Antibiotics toolkit’ in conjunction with the Health</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:312.69px' class='cls_002'><span class='cls_002'>Protection Agency and the Antimicrobial Stewardship in Primary Care.It includes training resources, resources for clinicians,</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:326.51px' class='cls_002'><span class='cls_002'>patient information leaflets, antibiotic guidance, a self assessment checklist and audit tools.It is available at the following</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:340.31px' class='cls_002'><span class='cls_002'>link: </span><A HREF = 'http://www.rcgp.org.uk/clinical-and-research/target-antibiotics-toolkit.aspx' > http://www.rcgp.org.uk/clinical-and-research/target-antibiotics-toolkit.aspx.</A> </span></div>" +
"<div style = 'position:absolute;left:72.00px;top:367.91px' class='cls_037'><span class='cls_037'>Clostridium difficile</span><span class='cls_034'>Infection(CDI)</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:396.23px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   All antibiotic prescribing should be within the recommendations of this guideline for the shortest period.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:410.75px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   When prescribing an antibiotic for any indication in patients who have had a previous</span><span class='cls_019'>Clostridium difficile</span><span class='cls_002'> infection, advice</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:424.67px' class='cls_002'><span class='cls_002'>should be sought from a microbiologist to avoid any potential relapse.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:438.23px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   Antibiotics that are associated with Clostridium difficile infection are highlighted in this guideline by the following symbol: </span><span class='cls_021'>♣</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:456.86px' class='cls_002'><span class='cls_002'>and should be avoided in ‘at risk’ groups such as the elderly and those in institutions.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:471.50px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   Current evidence has shown that clindamycin</span><span class='cls_016'>♣</span><span class='cls_002'> and second/third generation cephalosporins</span><span class='cls_016'>♣</span><span class='cls_002'> such as cefuroxime</span><span class='cls_016'>♣</span><span class='cls_002'>,</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:485.30px' class='cls_002'><span class='cls_002'>cefixime</span><span class='cls_016'>♣</span><span class='cls_002'>, cefotaxime</span><span class='cls_016'>♣</span><span class='cls_002'> and ceftriaxone</span><span class='cls_016'>♣</span><span class='cls_002'> are significantly more likely to cause CDI.Anecdotal evidence has also implicated</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>11</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:7639px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background12.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:108.02px;top:88.62px' class='cls_002'><span class='cls_002'>agents such as quinolones</span><span class='cls_016'>♣</span><span class='cls_002'>, first generation cephalosporins</span><span class='cls_016'>♣</span><span class='cls_002'> and co-amoxiclav</span><span class='cls_016'>♣</span><span class='cls_002'>. These agents should therefore be used</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:102.42px' class='cls_002'><span class='cls_002'>sparingly, especially in the elderly and for patients who live in institutions where CDI is present.They should also be avoided</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:116.22px' class='cls_002'><span class='cls_002'>in patients who have previously been treated for CDI.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:130.74px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   There is evidence that proton pump inhibitors(PPIs) increase the susceptibility to</span><span class='cls_019'>Clostridium difficile</span><span class='cls_002'> infection and the</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:144.54px' class='cls_002'><span class='cls_002'>prescribing of PPIs should therefore be considered carefully in at risk groups of patients and only be prescribed where there</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:158.34px' class='cls_002'><span class='cls_002'>is a clear clinical indication.There should be a regular review of the ongoing need for a PPI. Guidance on the prescribing of</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:172.02px' class='cls_002'><span class='cls_002'>PPIs to minimise the risk of</span><span class='cls_019'>Clostridium difficile</span><span class='cls_002'> infection can be found at: </span><A HREF = 'http://www.enhertsccg.nhs.uk/sites/default/files/Pharmacy/Local_Decisions/Proton%20Pump%20Inhibitor%20Guidance%20to%20minimise%20risk%20of%20C%20difficile%20infection%20%20201404%28HMMC%29.pdf' > ENHCCG </ A >< span class='cls_002'> and</span><A HREF = 'http://www.hertsvalleysccg.nhs.uk/uploads/file/Pharmacy/Local%20Decisions/Proton%20Pump%20Inhibitor%20Guidance%20to%20minimise%20risk%20of%20C%20difficile%20infection%20%20201404(HMMC).pdf' > HVCCG </ A > </ span >< span class='cls_002'> and guidance on the</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:185.94px' class='cls_002'><span class='cls_002'>prescribing of PPIs in dyspepsia in adults is available at: </span><A HREF = 'http://www.nice.org.uk/guidance/cg184' > Dyspepsia </ A > </ span ></ div >" +
"<div style='position:absolute;left:90.00px;top:200.61px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   Where possible, the prescriber should be guided by laboratory results.Where this is not possible a narrow spectrum</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:214.41px' class='cls_002'><span class='cls_002'>antibiotic should be selected.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:242.01px' class='cls_034'><span class='cls_034'>Pneumonia and C-reactive protein(CRP) test</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:269.61px' class='cls_002'><span class='cls_002'>NICE published a guideline in December 2014 on the treatment of pneumonia in both the community and hospital settings.In</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:283.41px' class='cls_002'><span class='cls_002'>primary care, the majority of patients without pneumonia present with symptoms of chest infection, and without access to chest X-</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:297.21px' class='cls_002'><span class='cls_002'>ray it is sometimes difficult to determine if symptoms are caused by pneumonia or a lower respiratory tract infection of which the</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:311.01px' class='cls_002'><span class='cls_002'>latter will resolve without antibiotic treatment.Antibiotics will benefit those patients who have a bacterial infection but will have no</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:324.83px' class='cls_002'><span class='cls_002'>effect on those with a viral infection and may actually cause harm.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:352.43px' class='cls_002'><span class='cls_002'>NICE are therefore recommending that in cases where patients present with symptoms of lower respiratory tract infection and</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:366.23px' class='cls_002'><span class='cls_002'>pneumonia is not evident after clinical assessment, GPs should consider carrying out a CRP test if it is not clear whether antibiotics</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:380.03px' class='cls_002'><span class='cls_002'>should be prescribed or not.The CRP test is an important tool that GPs can use and still be confident they are offering patients the</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:393.83px' class='cls_002'><span class='cls_002'>best treatment whilst reducing their antibiotic prescribing.The results of the CRP test can be used to guide antibiotic prescribing as</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:407.63px' class='cls_002'><span class='cls_002'>follows:</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:422.27px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   Do not routinely offer antibiotic treatment if the CRP concentration is less than 20mg/litre.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:436.91px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   Consider a delayed prescription if the CRP concentration is between 20mg/litre and 100mg/litre.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:451.43px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   Offer antibiotic therapy if the CRP concentration is greater than 100mg/litre.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:465.26px' class='cls_002'><span class='cls_002'>The full guideline can be found at the following link: </span><span class='cls_035'>http://www.nice.org.uk/guidance/cg191</span><span class='cls_002'>.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>12</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:8244px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background13.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:72.00px;top:88.62px' class='cls_034'><span class='cls_034'>Restricted antibiotics</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:116.22px' class='cls_002'><span class='cls_002'>These antibiotics are significantly more likely to cause CDI and are therefore restricted.They are marked by the following symbol: </span><span class='cls_016'>♣</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:130.02px' class='cls_002'><span class='cls_002'>and include cephalosporins</span><span class='cls_016'>♣, </span><span class='cls_002'>quinolones</span><span class='cls_016'>♣ </span><span class='cls_002'>and co-amoxiclav</span><span class='cls_016'>♣.</span><span class='cls_002'> Prescribers are reminded that recommendations to prescribe</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:143.82px' class='cls_002'><span class='cls_002'>restricted antibiotics appear in the following areas</span><span class='cls_038'>only</span><span class='cls_002'>:</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:157.62px' class='cls_005'><span class='cls_005'>Cephalosporins</span><span class='cls_016'>♣:</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:172.26px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:170.70px' class='cls_002'><span class='cls_002'>1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line in epididymo-orchitis</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:186.78px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:185.22px' class='cls_002'><span class='cls_002'>1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line in Pelvic inflammatory disease(PID) - high risk of gonorrhoea</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:201.45px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:199.89px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line in UTI in pregnancy</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:216.09px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:214.53px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line in Asymptomatic bacteriuria in pregnancy</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:230.73px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:229.17px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line acute pyelonephritis(pregnant)</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:258.21px' class='cls_005'><span class='cls_005'>Quinolones</span><span class='cls_016'>♣:</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:272.85px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:271.29px' class='cls_002'><span class='cls_002'>1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line in acute pyelonephritis</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:287.49px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:285.93px' class='cls_002'><span class='cls_002'>1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line in acute prostatitis</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:302.13px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:300.57px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line in Pelvic inflammatory disease(PID)</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:316.77px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:315.21px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line in diverticulitis</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:331.31px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:329.75px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line in epididymo-orchitis</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:345.83px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:344.27px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'>line in </span><span class='cls_019'>Helicobacter pylori</span><span class='cls_002'> eradication</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:373.55px' class='cls_005'><span class='cls_005'>Co-amoxiclav</span><span class='cls_016'>♣:</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:388.19px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:386.63px' class='cls_002'><span class='cls_002'>1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line in diverticulitis</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:402.71px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:401.15px' class='cls_002'><span class='cls_002'>1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line in bites</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:417.35px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:415.79px' class='cls_002'><span class='cls_002'>1</span><span class='cls_012'><sup>st</sup></span><span class='cls_002'> line in “dirty” post op wound infection</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:431.99px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:431.99px' class='cls_002'><span class='cls_002'>2nd line in acute pyelonephritis</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:446.63px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:445.07px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line in acute sinusitis(persistent symptoms)</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:461.18px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:459.62px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line in acute exacerbation of COPD(treatment failure)</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:475.82px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:474.26px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line in UTI in children(upper UTI)</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:490.46px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:488.90px' class='cls_002'><span class='cls_002'>2</span><span class='cls_012'><sup>nd</sup></span><span class='cls_002'> line in cellulitis(facial)</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>13</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:8849px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background14.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:72.00px;top:88.62px' class='cls_034'><span class='cls_034'>Guidance on Infection Control in Schools and Other Childcare Settings</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:116.22px' class='cls_002'><span class='cls_002'>Public Health England(PHE) have issued specific guidance to prescribers on how such infections should be managed and advice</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:130.02px' class='cls_002'><span class='cls_002'>that can be given to carers.This is available at:</span><A HREF = 'https://www.gov.uk/government/publications/infection-control-in-schools-poster./' > https://www.gov.uk/government/publications/infection-control-in-schools-poster.</A> </span></div>" +
"<div style = 'position:absolute;left:72.00px;top:143.82px' class='cls_002'><span class='cls_002'>PHE operate a website on ‘microbes’ that can be used in both primary and secondary schools.Plans and activities have been</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:157.62px' class='cls_002'><span class='cls_002'>designed to complement the national curriculum and further information can be found at: </span><A HREF = 'http://www.e-bug.eu/' > e - Bug.</ A > </ span ></ div >" +
"<div style='position:absolute;left:72.00px;top:185.22px' class='cls_034'><span class='cls_034'>Specific Drug Warnings</span><span class='cls_005'> - Refer to current BNF for full prescribing information</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:212.85px' class='cls_005'><span class='cls_005'>Co-amoxiclav</span><span class='cls_006'>♣</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:226.65px' class='cls_002'><span class='cls_002'>The Committee on the Safety of Medicines(CSM) has advised that cholestatic jaundice can occur either during or shortly after</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:240.45px' class='cls_002'><span class='cls_002'>treatment.An epidemiological study has shown that the risk of acute liver toxicity was about 6 times greater with co-amoxiclav than</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:254.25px' class='cls_002'><span class='cls_002'>with amoxicillin.Cholestatic jaundice is more common in patients over 65 and in men and rarely occurs in children.Jaundice is</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:268.05px' class='cls_002'><span class='cls_002'>usually self-limiting and very rarely fatal.Duration of treatment should not usually exceed 14 days.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:295.65px' class='cls_005'><span class='cls_005'>Erythromycin</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:309.45px' class='cls_002'><span class='cls_002'>Erythromycin interacts with many other medications, the majority of which are classified by the BNF as ‘potentially hazardous’.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:323.27px' class='cls_002'><span class='cls_002'>Please see appendix 1: interactions(macrolides) of the current BNF for further information.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:350.87px' class='cls_005'><span class='cls_005'>Flucloxacillin</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:364.67px' class='cls_002'><span class='cls_002'>The CSM has advised that very rarely cholestatic jaundice and hepatitis may occur up to 2 months after treatment with flucloxacillin</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:378.47px' class='cls_002'><span class='cls_002'>has been stopped.Administration for greater than 2 weeks and increasing age are risk factors.Flucloxacillin should not be used in</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:392.27px' class='cls_002'><span class='cls_002'>patients with a history of hepatic dysfunction associated with flucloxacillin and should be used with caution in patients with hepatic</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:406.07px' class='cls_002'><span class='cls_002'>impairment.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:433.67px' class='cls_005'><span class='cls_005'>Fosfomycin</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:447.35px' class='cls_002'><span class='cls_002'>Fosfomycin is a bactericidal antibacterial indicated for the treatment of lower UTI due to extended-spectrum beta-lactamase(ESBL)</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:461.18px' class='cls_002'><span class='cls_002'>-producing micro-organisms on the advice of a consultant microbiologist.It is licensed in the UK but not actively marketed. Supplies</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:474.98px' class='cls_002'><span class='cls_002'>therefore need to be imported and it becomes an unlicensed product as a result.Full prescribing information is available on</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:488.78px' class='cls_002'><span class='cls_002'>request.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>14</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:9454px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background15.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:72.00px;top:88.62px' class='cls_005'><span class='cls_005'>Itraconazole</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:102.42px' class='cls_002'><span class='cls_002'>Following rare reports of heart failure, the CSM has advised caution when prescribing itraconazole to patients at high risk of heart</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:116.22px' class='cls_002'><span class='cls_002'>failure.This includes patients who are receiving high doses and longer treatment courses, older patients, those with cardiac</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:130.02px' class='cls_002'><span class='cls_002'>disease and patients receiving treatment with negative inotropic drugs such as calcium channel blockers.Itraconazole should be</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:143.82px' class='cls_002'><span class='cls_002'>avoided in patients with ventricular dysfunction or a history of heart failure unless the infection is serious.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:171.42px' class='cls_005'><span class='cls_005'>Nitrofurantoin</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:183.66px' class='cls_002'><span class='cls_002'>Nitrofurantoin should not be used regularly if eGFR(</span><span class='cls_005'>e</span><span class='cls_002'>stimated</span><span class='cls_005'>G</span><span class='cls_002'>lomerular</span><span class='cls_005'>F</span><span class='cls_002'>iltration</span><span class='cls_005'>R</span><span class='cls_002'>ate) &lt; 45ml/minute/1.73m</span><span class='cls_012'><sup>2</sup></span><span class='cls_002'>. However, it may</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:197.49px' class='cls_002'><span class='cls_002'>be used for short courses of 3 to 7 days in those with an eGFR between 30 and 44ml/minute/1.73m</span><span class='cls_012'><sup>2</sup></span><span class='cls_002'>. Long term use of</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:212.85px' class='cls_002'><span class='cls_002'>nitrofurantoin is not advisable as it can cause pulmonary fibrosis, hepatic problems and peripheral neuropathy.Short term use of</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:226.65px' class='cls_002'><span class='cls_002'>nitrofurantoin is unlikely to cause problems to the foetus but the BNF advises to avoid at term.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:254.25px' class='cls_005'><span class='cls_005'>Pivmecillinam</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:268.05px' class='cls_002'><span class='cls_002'>Pivmecillinam is a penicillin-like beta-lactam antibiotic that can be used to treat UTIs.It is highly active against many gram negative</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:281.73px' class='cls_002'><span class='cls_002'>bacteria including</span><span class='cls_019'>Escherichia coli</span><span class='cls_002'>, klebsiella, enterobacter and salmonellae.It is not active against</span><span class='cls_019'>Pseudomonas aeruginosa</span><span class='cls_002'> or</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:295.65px' class='cls_002'><span class='cls_002'>enterococci.It should NOT be taken by patients who are allergic to penicillins/cephalosporins, patients with oesophageal strictures</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:309.45px' class='cls_002'><span class='cls_002'>or gastro-intestinal obstruction and patients with carnitine deficiency.Avoid use with patients taking sodium valproate or valproic</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:323.27px' class='cls_002'><span class='cls_002'>acid.For a full list of warnings and side effects, please refer to the latest BNF and the summary of product characteristics for</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:337.07px' class='cls_002'><span class='cls_002'>Selexid - </span><span class='cls_035'>http://www.medicines.org.uk/emc/medicine/2566</span><span class='cls_002'>.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:364.67px' class='cls_005'><span class='cls_005'>Quinolones</span><span class='cls_006'>♣</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:378.47px' class='cls_002'><span class='cls_002'>The CSM has warned that quinolones may induce convulsions in patients with or without a history of convulsions.Tendon damage</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:392.27px' class='cls_002'><span class='cls_002'>(including rupture) has been reported rarely in patients receiving quinolones.Tendon rupture may occur within 48 hours of starting</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:406.07px' class='cls_002'><span class='cls_002'>treatment and up to several months after stopping a quinolone.Quinolones are contra-indicated in patients with a history of tendon</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:419.87px' class='cls_002'><span class='cls_002'>disorders.Patients over 60 years or those concomitantly taking corticosteroids are at increased risk of tendon damage.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:445.07px' class='cls_005'><span class='cls_005'>Trimethoprim</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:458.90px' class='cls_002'><span class='cls_002'>Trimethoprim should not be used in those patients taking methotrexate or those who have a low folate status e.g.those who take</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:472.70px' class='cls_002'><span class='cls_002'>folate antagonists such as antiepileptics or those who have a low dietary folate intake unless they are taking folate supplements.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>15</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:10059px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background16.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:72.00px;top:88.62px' class='cls_034'><span class='cls_034'>Reference Sources Used</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:117.06px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:117.06px' class='cls_002'><span class='cls_002'>Public Health England et al.Patient leaflet ‘treating your Infection’ - published 2014. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:131.58px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:131.58px' class='cls_002'><span class='cls_002'>Royal College of General Practitioners.TARGET Antibiotics toolkit.Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:146.22px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:146.22px' class='cls_002'><span class='cls_002'>National Institute for Health and Care Excellence.CG184 Dyspepsia and Gastro oesophageal reflux disease - published</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:160.02px' class='cls_002'><span class='cls_002'>September 2014. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:174.66px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:174.66px' class='cls_002'><span class='cls_002'>Leo Laboratories Ltd.Summary of Product Characteristics(SPC) Selexid</span><span class='cls_035'>www.medicines.org.uk</span><span class='cls_002'>. Last revised April 2015.</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:188.49px' class='cls_002'><span class='cls_002'>Accessed June 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:203.13px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:203.13px' class='cls_002'><span class='cls_002'>National Institute for Health and Care Excellence.CG69 Prescribing of antibiotics for self-limiting respiratory tract infections -</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:216.81px' class='cls_002'><span class='cls_002'>July 2008. Accessed January 2015</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:231.45px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:231.45px' class='cls_002'><span class='cls_002'>NICE Clinical Knowledge Summaries.Current evidence references for individual infections -a service provided by the</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:245.25px' class='cls_002'><span class='cls_002'>National Institute for Health and Care Excellence.Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:259.89px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:259.89px' class='cls_002'><span class='cls_002'>National Institute for Health and Care Excellence.CG101 Management of Chronic Obstructive Pulmonary Disease in adults</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:273.69px' class='cls_002'><span class='cls_002'>in Primary and Secondary Care - June 2010. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:288.33px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:288.33px' class='cls_002'><span class='cls_002'>National Institute for Health and Care Excellence.CG191 Pneumonia: Diagnosis and Management of community and</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:302.13px' class='cls_002'><span class='cls_002'>hospital acquired pneumonia in adults - December 2014. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:316.77px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:316.77px' class='cls_002'><span class='cls_002'>British Thoracic Society.Community Acquired Pneumonia in Adults Guideline - updated 2015. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:331.31px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:331.31px' class='cls_002'><span class='cls_002'>Public Health England.Meningococcal Disease - published July 2014. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:345.95px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:345.95px' class='cls_002'><span class='cls_002'>National Institute for Health and Care Excellence.CG102 Bacterial meningitis and meningococcal septicaemia - September</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:359.75px' class='cls_002'><span class='cls_002'>2010. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:374.39px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:374.39px' class='cls_002'><span class='cls_002'>National Institute for Health and Care Excellence.QS90 Urinary tract infections in adults - June 2015. Accessed June 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:388.91px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:388.91px' class='cls_002'><span class='cls_002'>British Infection Association and Health Protection Agency.Diagnosis of UTI - Quick reference guide for primary care -</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:402.71px' class='cls_002'><span class='cls_002'>published April 2011. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:417.35px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:417.35px' class='cls_002'><span class='cls_002'>Public Health England.Extended spectrum beta lactamases - July 2014. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:431.99px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:431.99px' class='cls_002'><span class='cls_002'>National Institute for Health and Care Excellence.KTT10 Three day courses of Antibiotics for Uncomplicated Urinary Tract</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:445.79px' class='cls_002'><span class='cls_002'>Infection - January 2015. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:460.46px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:460.46px' class='cls_002'><span class='cls_002'>Scottish Intercollegiate Guidelines Network.SIGN 88 Management of suspected bacterial urinary tract infection in adults -</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:474.14px' class='cls_002'><span class='cls_002'>updated July 2012. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated.Please refer to latest BNF for</span></div>" +
"<div style = 'position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>16</span></div>" +
"<div style = 'position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information.Published date: July 2015</span></div>" +
"</div>" +
"<div style = 'position:absolute;left:50%;margin-left:-420px;top:10664px;width:841px;height:595px;border-style:outset;overflow:hidden' >" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src = 'ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background17.jpg' width=841 height=595></div>" +
"<div style = 'position:absolute;left:90.00px;top:89.46px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:89.46px' class='cls_002'><span class='cls_002'>National Institute for Health and Care Excellence.CG54 Urinary tract infection in children - August 2007. Accessed January</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:103.14px' class='cls_002'><span class='cls_002'>2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:117.66px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:117.66px' class='cls_002'><span class='cls_002'>Public Health England. </span><span class='cls_019'>Clostridium difficile</span><span class='cls_002'> infection - published July 2014. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:132.30px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:132.30px' class='cls_002'><span class='cls_002'>Public Health England. </span><span class='cls_019'>Helicobacter pylori</span><span class='cls_002'> - updated September 2012. Accessed January 2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:147.06px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style = 'position:absolute;left:108.02px;top:147.06px' class='cls_002'><span class='cls_002'>British Association for Sexual Health and HIV.Current guidelines for individual genital tract infections. Accessed January</span></div>" +
"<div style = 'position:absolute;left:108.02px;top:160.86px' class='cls_002'><span class='cls_002'>2015.</span></div>" +
"<div style = 'position:absolute;left:90.00px;top:175.50px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style='position:absolute;left:108.02px;top:175.50px' class='cls_002'><span class='cls_002'>Public Health England. Management and laboratory diagnosis of abnormal vaginal discharge - Updated July 2013.</span></div>" +
"<div style='position:absolute;left:108.02px;top:189.21px' class='cls_002'><span class='cls_002'>Accessed January 2015.</span></div>" +
"<div style='position:absolute;left:90.00px;top:203.85px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style='position:absolute;left:108.02px;top:203.85px' class='cls_002'><span class='cls_002'>Public Health England. Chlamydia - Updated November 2014. Accessed January 2015.</span></div>" +
"<div style='position:absolute;left:90.00px;top:218.49px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style='position:absolute;left:108.02px;top:218.49px' class='cls_002'><span class='cls_002'>NHS Hertfordshire Primary Care Medicines Management Group. Why are fungal nail infections not routinely treated by the</span></div>" +
"<div style='position:absolute;left:108.02px;top:232.29px' class='cls_002'><span class='cls_002'>NHS in Hertfordshire? Published July 2012. Accessed January 2015.</span></div>" +
"<div style='position:absolute;left:90.00px;top:246.81px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style='position:absolute;left:108.02px;top:246.81px' class='cls_002'><span class='cls_002'>Public Health England. Diagnosis and Management of PVL - </span><span class='cls_019'>Staphylococcus aureus</span><span class='cls_002'> Infections Quick reference guide for</span></div>" +
"<div style='position:absolute;left:108.02px;top:260.73px' class='cls_002'><span class='cls_002'>primary care - Published May 2009. Accessed January 2015.</span></div>" +
"<div style='position:absolute;left:90.00px;top:275.37px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style='position:absolute;left:108.02px;top:275.37px' class='cls_002'><span class='cls_002'>.British National Formulary No 68 - September 2014. Accessed January 2015.</span></div>" +
"<div style='position:absolute;left:90.00px;top:289.77px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style='position:absolute;left:108.02px;top:289.77px' class='cls_002'><span class='cls_002'>UK Medicines Information. </span><span class='cls_019'>Clostridium difficile</span><span class='cls_002'> infection - which antimicrobials are implicated? Q&A 242.2aNovember 2012.</span></div>" +
"<div style='position:absolute;left:108.02px;top:303.69px' class='cls_002'><span class='cls_002'>Accessed January 2015.</span></div>" +
"<div style='position:absolute;left:90.00px;top:318.33px' class='cls_017'><span class='cls_017'></span></div>" +
"<div style='position:absolute;left:108.02px;top:318.33px' class='cls_002'><span class='cls_002'>Public Health England. Management of Infection Guidance for Primary Care - for Consultation and Local Adaptation -</span></div>" +
"<div style='position:absolute;left:108.02px;top:332.15px' class='cls_002'><span class='cls_002'>October 2014. Accessed January 2015.</span></div>" +
"<div style='position:absolute;left:72.00px;top:359.75px' class='cls_034'><span class='cls_034'>Acknowledgements</span></div>" +
"<div style='position:absolute;left:72.00px;top:387.35px' class='cls_002'><span class='cls_002'>The authors would like to thank the many health care professionals whose insightful and valuable comments helped to shape this</span></div>" +
"<div style='position:absolute;left:72.00px;top:401.15px' class='cls_002'><span class='cls_002'>document.</span></div>" +
"<div style='position:absolute;left:72.00px;top:414.95px' class='cls_002'><span class='cls_002'>Other NHS organisations.</span></div>" +
"<div style='position:absolute;left:72.00px;top:442.55px' class='cls_034'><span class='cls_034'>Comments</span></div>" +
"<div style='position:absolute;left:72.00px;top:470.18px' class='cls_002'><span class='cls_002'>Comments are welcome and should be directed to Alison Dossetter - Senior Pharmaceutical Adviser and Pharmacy and Medicines</span></div>" +
"<div style='position:absolute;left:72.00px;top:483.98px' class='cls_002'><span class='cls_002'>Optimisation Team lead for antibiotics (East and North Herts CCG) at: </span><A HREF='mailto:alison.dossetter@enhertsccg.nhs.uk'>alison.dossetter@enhertsccg.nhs.uk</A> </span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>17</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:11269px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background18.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:72.00px;top:122.10px' class='cls_023'><span class='cls_023'>UPPER RESPIRATORY TRACT INFECTIONS </span><A HREF='http://pathways.nice.org.uk/pathways/self-limiting-respiratory-tract-infections---antibiotic-prescribing#content=view-node%3Anodes-no-antibiotic-prescribin'>NICE - Self-limiting respiratory tract infections</A> </span></div>" +
"<div style='position:absolute;left:204.98px;top:141.18px' class='cls_010'><span class='cls_010'>The majority of sore throats are viral but there is clinical</span></div>" +
"<div style='position:absolute;left:204.98px;top:152.70px' class='cls_010'><span class='cls_010'>overlap between viral and streptococcal infections.</span></div>" +
"<div style='position:absolute;left:204.98px;top:164.22px' class='cls_010'><span class='cls_010'>Consider delayed script as antibiotics generally shorten</span></div>" +
"<div style='position:absolute;left:204.98px;top:175.74px' class='cls_010'><span class='cls_010'>duration of symptoms by 8 hours. Patients with 3 or 4</span></div>" +
"<div style='position:absolute;left:204.98px;top:187.26px' class='cls_010'><span class='cls_010'>Centor criteria (history of fever, purulent or enlarged</span></div>" +
"<div style='position:absolute;left:467.33px;top:185.34px' class='cls_010'><span class='cls_010'>Do not routinely</span></div>" +
"<div style='position:absolute;left:587.71px;top:187.26px' class='cls_010'><span class='cls_010'>Phenoxymethylpenicillin</span></div>" +
"<div style='position:absolute;left:708.34px;top:193.05px' class='cls_010'><span class='cls_010'>10 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:198.81px' class='cls_010'><span class='cls_010'>tonsils, cervical adenopathy, absence of cough) or</span></div>" +
"<div style='position:absolute;left:467.33px;top:196.89px' class='cls_010'><span class='cls_010'>prescribe antibiotics.</span></div>" +
"<div style='position:absolute;left:587.71px;top:198.81px' class='cls_010'><span class='cls_010'>500mg QDS</span></div>" +
"<div style='position:absolute;left:72.00px;top:202.65px' class='cls_010'><span class='cls_010'>Pharyngitis / sore throat /</span></div>" +
"<div style='position:absolute;left:204.98px;top:210.21px' class='cls_010'><span class='cls_010'>history of otitis media may benefit from antibiotics.</span></div>" +
"<div style='position:absolute;left:467.33px;top:208.41px' class='cls_010'><span class='cls_010'>Consider a delayed</span></div>" +
"<div style='position:absolute;left:72.00px;top:214.17px' class='cls_010'><span class='cls_010'>tonsillitis</span></div>" +
"<div style='position:absolute;left:204.98px;top:221.73px' class='cls_010'><span class='cls_010'>Prescribe an antibiotic for those with features of marked</span></div>" +
"<div style='position:absolute;left:467.33px;top:219.93px' class='cls_010'><span class='cls_010'>prescribing strategy.</span></div>" +
"<div style='position:absolute;left:204.98px;top:233.25px' class='cls_010'><span class='cls_010'>systemic upset, an increased risk of serious</span></div>" +
"<div style='position:absolute;left:467.33px;top:231.33px' class='cls_010'><span class='cls_010'>Majority of infections are</span></div>" +
"<div style='position:absolute;left:204.98px;top:244.77px' class='cls_010'><span class='cls_010'>complications and patients with valvular heart disease.</span></div>" +
"<div style='position:absolute;left:467.33px;top:242.85px' class='cls_010'><span class='cls_010'>viral and resolve within 1</span></div>" +
"<div style='position:absolute;left:467.33px;top:254.37px' class='cls_010'><span class='cls_010'>week.</span></div>" +
"<div style='position:absolute;left:587.71px;top:271.89px' class='cls_010'><span class='cls_010'>Clarithromycin</span></div>" +
"<div style='position:absolute;left:204.98px;top:277.65px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/sore-throat-acute'>CKS - Sore Throat</A></div>" +
"<div style='position:absolute;left:708.34px;top:277.65px' class='cls_010'><span class='cls_010'>5 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:283.41px' class='cls_010'><span class='cls_010'>500mg BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:310.53px' class='cls_010'><span class='cls_010'>60% of attacks resolve within 24 hours without</span></div>" +
"<div style='position:absolute;left:204.98px;top:322.05px' class='cls_010'><span class='cls_010'>antibiotics. They only reduce pain at 2 days and do not</span></div>" +
"<div style='position:absolute;left:204.98px;top:333.47px' class='cls_010'><span class='cls_010'>prevent deafness. Offer an immediate antibiotic</span></div>" +
"<div style='position:absolute;left:204.98px;top:344.99px' class='cls_010'><span class='cls_010'>prescription if:</span></div>" +
"<div style='position:absolute;left:222.98px;top:357.23px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    Patient is systemically unwell</span></div>" +
"<div style='position:absolute;left:222.98px;top:369.35px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    Patient at high risk of serious complications</span></div>" +
"<div style='position:absolute;left:467.33px;top:371.15px' class='cls_010'><span class='cls_010'>Do not routinely</span></div>" +
"<div style='position:absolute;left:587.71px;top:376.91px' class='cls_010'><span class='cls_010'>Amoxicillin or</span></div>" +
"<div style='position:absolute;left:222.98px;top:381.59px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    Patients with symptoms for > 4 days and are not</span></div>" +
"<div style='position:absolute;left:467.33px;top:382.67px' class='cls_010'><span class='cls_010'>prescribe antibiotics. For</span></div>" +
"<div style='position:absolute;left:587.71px;top:388.43px' class='cls_010'><span class='cls_010'>clarithromycin (penicillin</span></div>" +
"<div style='position:absolute;left:72.00px;top:394.19px' class='cls_010'><span class='cls_010'>Otitis media (acute)</span></div>" +
"<div style='position:absolute;left:240.98px;top:392.99px' class='cls_010'><span class='cls_010'>improving.</span></div>" +
"<div style='position:absolute;left:467.33px;top:394.19px' class='cls_010'><span class='cls_010'>acute attacks with no</span></div>" +
"<div style='position:absolute;left:587.71px;top:399.95px' class='cls_010'><span class='cls_010'>allergy). Consult current</span></div>" +
"<div style='position:absolute;left:708.34px;top:399.95px' class='cls_010'><span class='cls_010'>5 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:404.51px' class='cls_010'><span class='cls_010'>Consider 2 or 3 day delayed prescription or immediate</span></div>" +
"<div style='position:absolute;left:467.33px;top:405.71px' class='cls_010'><span class='cls_010'>systemic features advise</span></div>" +
"<div style='position:absolute;left:587.71px;top:411.47px' class='cls_010'><span class='cls_010'>BNF for Children for</span></div>" +
"<div style='position:absolute;left:204.98px;top:416.03px' class='cls_010'><span class='cls_010'>antibiotics for pain relief if:</span></div>" +
"<div style='position:absolute;left:467.33px;top:417.23px' class='cls_010'><span class='cls_010'>paracetamol or</span></div>" +
"<div style='position:absolute;left:587.71px;top:422.87px' class='cls_010'><span class='cls_010'>doses.</span></div>" +
"<div style='position:absolute;left:222.98px;top:428.27px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:240.98px;top:428.27px' class='cls_010'><span class='cls_010'>&lt; 2 years with bilateral acute otitis media (AOM)</span></div>" +
"<div style='position:absolute;left:467.33px;top:428.63px' class='cls_010'><span class='cls_010'>ibuprofen for pain.</span></div>" +
"<div style='position:absolute;left:240.98px;top:439.67px' class='cls_010'><span class='cls_010'>or bulging membrane and ≥ 4 marked symptoms</span></div>" +
"<div style='position:absolute;left:222.98px;top:451.91px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    All ages with otorrhoea</span></div>" +
"<div style='position:absolute;left:204.98px;top:482.42px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/otitis-media-acute'>CKS - Otitis media</A></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>18</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:11874px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background19.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>Remove or treat any aggravating or precipitating factors.</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_010'><span class='cls_010'>Treat inflammation with a topical ear preparation and</span></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_010'><span class='cls_010'>consider cleaning the external auditory canal if there is</span></div>" +
"<div style='position:absolute;left:204.98px;top:149.82px' class='cls_010'><span class='cls_010'>sufficient ear wax or debris to obstruct topical</span></div>" +
"<div style='position:absolute;left:204.98px;top:161.22px' class='cls_010'><span class='cls_010'>medication. Only consider adding an oral antibiotic for</span></div>" +
"<div style='position:absolute;left:204.98px;top:172.74px' class='cls_010'><span class='cls_010'>patients with severe infection. If an oral antibiotic is</span></div>" +
"<div style='position:absolute;left:587.71px;top:174.30px' class='cls_010'><span class='cls_010'>Acetic Acid 2% Spray</span></div>" +
"<div style='position:absolute;left:204.98px;top:184.26px' class='cls_010'><span class='cls_010'>required, consider a 7 day course of flucloxacillin or</span></div>" +
"<div style='position:absolute;left:467.33px;top:185.70px' class='cls_010'><span class='cls_010'>Do not routinely</span></div>" +
"<div style='position:absolute;left:587.71px;top:185.70px' class='cls_010'><span class='cls_010'>TDS. For more severe</span></div>" +
"<div style='position:absolute;left:204.98px;top:195.81px' class='cls_010'><span class='cls_010'>clarithromycin if the patient is penicillin allergic.</span></div>" +
"<div style='position:absolute;left:467.33px;top:197.25px' class='cls_010'><span class='cls_010'>prescribe oral antibiotics</span></div>" +
"<div style='position:absolute;left:587.71px;top:197.25px' class='cls_010'><span class='cls_010'>cases (pain, deafness,</span></div>" +
"<div style='position:absolute;left:72.00px;top:203.01px' class='cls_010'><span class='cls_010'>Otitis Externa (acute)</span></div>" +
"<div style='position:absolute;left:708.34px;top:203.01px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:207.33px' class='cls_010'><span class='cls_010'>Do NOT prescribe chloramphenicol ear drops as they</span></div>" +
"<div style='position:absolute;left:467.33px;top:208.77px' class='cls_010'><span class='cls_010'>and advise use of</span></div>" +
"<div style='position:absolute;left:587.71px;top:208.77px' class='cls_010'><span class='cls_010'>discharge) consider a</span></div>" +
"<div style='position:absolute;left:204.98px;top:218.85px' class='cls_010'><span class='cls_010'>can cause dermatitis in about 10% of patients.</span></div>" +
"<div style='position:absolute;left:467.33px;top:220.29px' class='cls_010'><span class='cls_010'>adequate analgesia.</span></div>" +
"<div style='position:absolute;left:587.71px;top:220.29px' class='cls_010'><span class='cls_010'>topical antibiotic with or</span></div>" +
"<div style='position:absolute;left:204.98px;top:230.25px' class='cls_010'><span class='cls_010'>Do NOT prescribe fluoroquinolone</span><span class='cls_011'>♣</span><span class='cls_010'> ear drops</span></div>" +
"<div style='position:absolute;left:587.71px;top:231.81px' class='cls_010'><span class='cls_010'>without a corticosteroid.</span></div>" +
"<div style='position:absolute;left:204.98px;top:241.77px' class='cls_010'><span class='cls_010'>(ciprofloxacin</span><span class='cls_011'>♣</span><span class='cls_010'> or ofloxacin</span><span class='cls_011'>♣</span><span class='cls_010'>) as they are unlicensed.</span></div>" +
"<div style='position:absolute;left:204.98px;top:253.29px' class='cls_010'><span class='cls_010'>Fluoroquinolone</span><span class='cls_011'>♣</span><span class='cls_010'> eye drops are also unlicensed for use</span></div>" +
"<div style='position:absolute;left:204.98px;top:264.81px' class='cls_010'><span class='cls_010'>in the ear.</span></div>" +
"<div style='position:absolute;left:204.98px;top:283.77px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/otitis-externa'>CKS - Otitis externa</A></div>" +
"<div style='position:absolute;left:204.98px;top:302.73px' class='cls_010'><span class='cls_010'>Many attacks are viral and symptomatic benefit of</span></div>" +
"<div style='position:absolute;left:204.98px;top:314.25px' class='cls_010'><span class='cls_010'>antibiotics is small - 80% resolve within 14 days without</span></div>" +
"<div style='position:absolute;left:467.33px;top:314.25px' class='cls_010'><span class='cls_010'>Do not routinely</span></div>" +
"<div style='position:absolute;left:204.98px;top:325.79px' class='cls_010'><span class='cls_010'>antibiotics. Consider an immediate script if patient is</span></div>" +
"<div style='position:absolute;left:467.33px;top:325.79px' class='cls_010'><span class='cls_010'>prescribe antibiotics and</span></div>" +
"<div style='position:absolute;left:587.71px;top:331.55px' class='cls_010'><span class='cls_010'>Amoxicillin 500 mg TDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:337.31px' class='cls_010'><span class='cls_010'>systemically unwell, has co-morbidities or when purulent</span></div>" +
"<div style='position:absolute;left:467.33px;top:337.31px' class='cls_010'><span class='cls_010'>advise use of adequate</span></div>" +
"<div style='position:absolute;left:587.71px;top:343.07px' class='cls_010'><span class='cls_010'>or Clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:348.71px' class='cls_010'><span class='cls_010'>nasal discharge is present.</span></div>" +
"<div style='position:absolute;left:467.33px;top:348.71px' class='cls_010'><span class='cls_010'>analgesia. Only</span></div>" +
"<div style='position:absolute;left:587.71px;top:354.47px' class='cls_010'><span class='cls_010'>BD or doxycycline</span></div>" +
"<div style='position:absolute;left:467.33px;top:360.23px' class='cls_010'><span class='cls_010'>prescribe antibiotics for</span></div>" +
"<div style='position:absolute;left:587.71px;top:365.99px' class='cls_010'><span class='cls_010'>200mg stat then 100mg</span></div>" +
"<div style='position:absolute;left:467.33px;top:371.75px' class='cls_010'><span class='cls_010'>those at high risk of</span></div>" +
"<div style='position:absolute;left:587.71px;top:377.51px' class='cls_010'><span class='cls_010'>OD. Consider</span></div>" +
"<div style='position:absolute;left:72.00px;top:383.27px' class='cls_010'><span class='cls_010'>Sinusitis (acute)</span></div>" +
"<div style='position:absolute;left:467.33px;top:383.27px' class='cls_010'><span class='cls_010'>complications or when</span></div>" +
"<div style='position:absolute;left:587.71px;top:389.03px' class='cls_010'><span class='cls_010'>erythromycin for</span></div>" +
"<div style='position:absolute;left:708.34px;top:389.03px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:394.79px' class='cls_010'><span class='cls_010'>acute bacterial sinusitis</span></div>" +
"<div style='position:absolute;left:204.98px;top:400.79px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/sinusitis'>CKS - Sinusitis</A></div>" +
"<div style='position:absolute;left:587.71px;top:400.55px' class='cls_010'><span class='cls_010'>pregnant women and</span></div>" +
"<div style='position:absolute;left:467.33px;top:406.31px' class='cls_010'><span class='cls_010'>is suspected.</span></div>" +
"<div style='position:absolute;left:587.71px;top:411.95px' class='cls_010'><span class='cls_010'>co-amoxiclav</span><span class='cls_011'>♣</span><span class='cls_010'> for</span></div>" +
"<div style='position:absolute;left:587.71px;top:423.47px' class='cls_010'><span class='cls_010'>persistent symptoms.</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>19</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:12479px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background20.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:72.00px;top:115.14px' class='cls_023'><span class='cls_023'>LOWER RESPIRATORY TRACT INFECTIONS </span><span class='cls_027'>Low doses of penicillins are more likely to select out resistance. Do NOT use quinolones first line due to poor</span></div>" +
"<div style='position:absolute;left:72.00px;top:126.78px' class='cls_027'><span class='cls_027'>pneumococcal activity. Reserve all quinolones for proven resistant organisms. For people presenting with symptoms of LRTI and in whom after clinical</span></div>" +
"<div style='position:absolute;left:72.00px;top:138.30px' class='cls_027'><span class='cls_027'>assessment a diagnosis of pneumonia has not been made and it is not clear whether antibiotics should be prescribed, </span><A HREF='http://www.nice.org.uk/guidance/cg191/chapter/1-recommendations'>NICE</A> </span><span class='cls_027'> have recommended that a point</span></div>" +
"<div style='position:absolute;left:72.00px;top:149.82px' class='cls_027'><span class='cls_027'>of care C-reactive protein test (CRP) be considered. Do NOT routinely offer antibiotics if CRP&lt;20mg/litre, consider a delayed prescription if CRP is between</span></div>" +
"<div style='position:absolute;left:72.00px;top:161.22px' class='cls_027'><span class='cls_027'>20mg/litre and 100mg/litre and offer antibiotic therapy if CRP is > 100mg/litre. See individual pneumonia section at the beginning of the document for more</span></div>" +
"<div style='position:absolute;left:72.00px;top:172.74px' class='cls_027'><span class='cls_027'>details.</span></div>" +
"<div style='position:absolute;left:204.98px;top:184.62px' class='cls_009'><span class='cls_009'>Send sputum for culture and sensitivity testing</span></div>" +
"<div style='position:absolute;left:204.98px;top:196.17px' class='cls_009'><span class='cls_009'>BEFORE starting antibiotics</span><span class='cls_010'>. If there is no previous</span></div>" +
"<div style='position:absolute;left:204.98px;top:207.81px' class='cls_010'><span class='cls_010'>bacteriology available, promptly prescribe an antibiotic</span></div>" +
"<div style='position:absolute;left:204.98px;top:219.33px' class='cls_010'><span class='cls_010'>as indicated and do not await the results of culture.</span></div>" +
"<div style='position:absolute;left:587.71px;top:225.33px' class='cls_041'><span class='cls_041'>Penicillin allergy</span></div>" +
"<div style='position:absolute;left:204.98px;top:230.85px' class='cls_010'><span class='cls_010'>Review the response to empirical treatment when</span></div>" +
"<div style='position:absolute;left:72.00px;top:236.85px' class='cls_010'><span class='cls_010'>Bronchiectasis (infective</span></div>" +
"<div style='position:absolute;left:587.71px;top:236.85px' class='cls_010'><span class='cls_010'>Clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:242.25px' class='cls_010'><span class='cls_010'>culture and sensitivity results are available. . If culture</span></div>" +
"<div style='position:absolute;left:72.00px;top:248.25px' class='cls_010'><span class='cls_010'>exacerbation of non CF</span></div>" +
"<div style='position:absolute;left:467.33px;top:248.25px' class='cls_010'><span class='cls_010'>Amoxicillin 500mg TDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:248.25px' class='cls_010'><span class='cls_010'>BD or Doxycycline</span></div>" +
"<div style='position:absolute;left:708.34px;top:248.25px' class='cls_010'><span class='cls_010'>10 to 14 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:253.77px' class='cls_010'><span class='cls_010'>and sensitivity results are available, prescribe according</span></div>" +
"<div style='position:absolute;left:72.00px;top:259.77px' class='cls_010'><span class='cls_010'>patients)</span></div>" +
"<div style='position:absolute;left:587.71px;top:259.77px' class='cls_010'><span class='cls_010'>200mg stat then 100mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:265.29px' class='cls_010'><span class='cls_010'>to advice or according to the CKS and BTS links below.</span></div>" +
"<div style='position:absolute;left:587.71px;top:271.29px' class='cls_010'><span class='cls_010'>OD</span></div>" +
"<div style='position:absolute;left:204.98px;top:277.29px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/bronchiectasis#!management'>CKS - Bronchiectasis</A></div>" +
"<div style='position:absolute;left:204.98px;top:300.33px' class='cls_040'><span class='cls_040'> </span><A HREF='https://www.brit-thoracic.org.uk/document-library/clinical-information/bronchiectasis/bts-guideline-for-non-cf-bronchiectasis/'>BTS - Non CF Bronchiectasis</A></div>" +
"<div style='position:absolute;left:204.98px;top:323.85px' class='cls_010'><span class='cls_010'>Antibiotics should be reserved for patients where there is</span></div>" +
"<div style='position:absolute;left:204.98px;top:335.27px' class='cls_010'><span class='cls_010'>a risk of serious harm from even a modest deterioration</span></div>" +
"<div style='position:absolute;left:204.98px;top:346.79px' class='cls_010'><span class='cls_010'>in their chronic condition. The benefits of antibiotics are</span></div>" +
"<div style='position:absolute;left:204.98px;top:358.31px' class='cls_010'><span class='cls_010'>marginal in otherwise healthy adults. The use of a</span></div>" +
"<div style='position:absolute;left:204.98px;top:369.83px' class='cls_010'><span class='cls_010'>delayed prescribing tactic and leaflets explaining the</span></div>" +
"<div style='position:absolute;left:204.98px;top:381.35px' class='cls_010'><span class='cls_010'>nature of the illness and why antibiotics are not</span></div>" +
"<div style='position:absolute;left:587.71px;top:387.83px' class='cls_010'><span class='cls_010'>Doxycycline 200mg stat</span></div>" +
"<div style='position:absolute;left:204.98px;top:392.75px' class='cls_010'><span class='cls_010'>necessary, may be helpful. Consider immediate</span></div>" +
"<div style='position:absolute;left:72.00px;top:399.35px' class='cls_010'><span class='cls_010'>Bronchitis (acute)</span></div>" +
"<div style='position:absolute;left:587.71px;top:399.35px' class='cls_010'><span class='cls_010'>then 100mg OD or</span></div>" +
"<div style='position:absolute;left:204.98px;top:404.27px' class='cls_010'><span class='cls_010'>antibiotics if > 80 years and ONE of: hospitalisation in</span></div>" +
"<div style='position:absolute;left:467.33px;top:405.11px' class='cls_010'><span class='cls_010'>Amoxicillin 500mg TDS</span></div>" +
"<div style='position:absolute;left:708.34px;top:405.11px' class='cls_010'><span class='cls_010'>5 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:410.87px' class='cls_010'><span class='cls_010'>clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:415.79px' class='cls_010'><span class='cls_010'>last year, oral steroids, diabetic, congestive heart failure</span></div>" +
"<div style='position:absolute;left:587.71px;top:422.39px' class='cls_010'><span class='cls_010'>BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:427.31px' class='cls_010'><span class='cls_010'>OR > 65 years with 2 of above.</span></div>" +
"<div style='position:absolute;left:204.98px;top:451.31px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/chest-infections-adult'>CKS - Acute bronchitis</A></div>" +
"<div style='position:absolute;left:204.98px;top:474.38px' class='cls_040'><span class='cls_040'> </span><A HREF='http://pathways.nice.org.uk/pathways/self-limiting-respiratory-tract-infections---antibiotic-prescribing#content=view-node%3Anodes-no-antibiotic-prescribin'>NICE - Self-limiting respiratory tract infections</A></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>20</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:13084px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background21.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>Treat exacerbations promptly with antibiotics if purulent</span></div>" +
"<div style='position:absolute;left:587.71px;top:122.94px' class='cls_010'><span class='cls_010'>Clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_010'><span class='cls_010'>sputum or clinical signs of pneumonia. Risk factors for</span></div>" +
"<div style='position:absolute;left:587.71px;top:134.34px' class='cls_010'><span class='cls_010'>BD or</span></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_010'><span class='cls_010'>antibiotic resistant organisms include co-morbidities,</span></div>" +
"<div style='position:absolute;left:204.98px;top:149.82px' class='cls_010'><span class='cls_010'>severe COPD, frequent exacerbations or antibiotic</span></div>" +
"<div style='position:absolute;left:587.71px;top:145.62px' class='cls_010'><span class='cls_010'>Co-amoxiclav</span><span class='cls_016'>♣</span><span class='cls_010'> 625mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:161.22px' class='cls_010'><span class='cls_010'>treatment within last 3 months. Oral steroids may be</span></div>" +
"<div style='position:absolute;left:587.71px;top:159.66px' class='cls_010'><span class='cls_010'>TDS (only if patient has</span></div>" +
"<div style='position:absolute;left:72.00px;top:169.98px' class='cls_010'><span class='cls_010'>Acute exacerbation of</span></div>" +
"<div style='position:absolute;left:467.33px;top:169.98px' class='cls_010'><span class='cls_010'>Amoxicillin 500mg TDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:172.74px' class='cls_010'><span class='cls_010'>considered in conjunction with antibiotics where</span></div>" +
"<div style='position:absolute;left:587.71px;top:171.18px' class='cls_010'><span class='cls_010'>antibiotic resistance</span></div>" +
"<div style='position:absolute;left:72.00px;top:181.50px' class='cls_010'><span class='cls_010'>COPD</span></div>" +
"<div style='position:absolute;left:467.33px;top:181.50px' class='cls_010'><span class='cls_010'>or Doxycycline 200mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:182.70px' class='cls_010'><span class='cls_010'>factors such as</span></div>" +
"<div style='position:absolute;left:708.34px;top:181.50px' class='cls_010'><span class='cls_010'>5 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:184.26px' class='cls_010'><span class='cls_010'>increased breathlessness interferes with the activities of</span></div>" +
"<div style='position:absolute;left:204.98px;top:195.81px' class='cls_010'><span class='cls_010'>daily living.</span></div>" +
"<div style='position:absolute;left:467.33px;top:193.05px' class='cls_010'><span class='cls_010'>stat then 100mg OD</span></div>" +
"<div style='position:absolute;left:587.71px;top:194.25px' class='cls_010'><span class='cls_010'>comorbid disease,</span></div>" +
"<div style='position:absolute;left:587.71px;top:205.65px' class='cls_010'><span class='cls_010'>severe COPD, frequent</span></div>" +
"<div style='position:absolute;left:587.71px;top:217.17px' class='cls_010'><span class='cls_010'>exacerbations or</span></div>" +
"<div style='position:absolute;left:204.98px;top:222.09px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/chronic-obstructive-pulmonary-disease'>CKS - COPD</A></div>" +
"<div style='position:absolute;left:587.71px;top:228.69px' class='cls_010'><span class='cls_010'>antibiotic use in the last</span></div>" +
"<div style='position:absolute;left:587.71px;top:240.21px' class='cls_010'><span class='cls_010'>3 months)</span></div>" +
"<div style='position:absolute;left:204.98px;top:245.01px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.nice.org.uk/guidance/cg101/chapter/1-guidance#/management-of-exacerbations-of-copd'>NICE - COPD</A></div>" +
"<div style='position:absolute;left:204.98px;top:259.65px' class='cls_009'><span class='cls_009'>Start antibiotics immediately</span><span class='cls_010'>. Use </span><span class='cls_009'>CRB65</span><span class='cls_010'> score to</span></div>" +
"<div style='position:absolute;left:204.98px;top:271.29px' class='cls_010'><span class='cls_010'>help guide and review.</span></div>" +
"<div style='position:absolute;left:204.98px;top:282.81px' class='cls_010'><span class='cls_010'>0 = suitable for home treatment.</span></div>" +
"<div style='position:absolute;left:204.98px;top:294.33px' class='cls_010'><span class='cls_010'>1-2 = hospital assessment or admission.</span></div>" +
"<div style='position:absolute;left:467.33px;top:300.09px' class='cls_010'><span class='cls_010'>If CRB65 score = 0</span></div>" +
"<div style='position:absolute;left:587.71px;top:300.09px' class='cls_010'><span class='cls_010'>Clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:305.85px' class='cls_010'><span class='cls_010'>3-4 = Urgent admission.</span></div>" +
"<div style='position:absolute;left:467.33px;top:311.49px' class='cls_010'><span class='cls_010'>Amoxicillin 500mg TDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:311.49px' class='cls_010'><span class='cls_010'>BD or Doxycycline</span></div>" +
"<div style='position:absolute;left:204.98px;top:317.13px' class='cls_010'><span class='cls_010'>Each scores 1: </span><span class='cls_009'>C</span><span class='cls_010'>onfusion (AMT&lt;8); </span><span class='cls_009'>R</span><span class='cls_010'>espiratory rate ></span></div>" +
"<div style='position:absolute;left:708.34px;top:317.25px' class='cls_010'><span class='cls_010'>5 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:323.01px' class='cls_010'><span class='cls_010'>200mg stat then 100mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:328.67px' class='cls_010'><span class='cls_010'>30/minute; </span><span class='cls_009'>B</span><span class='cls_010'>P systolic &lt;90 or diastolic ≤60; Age > </span><span class='cls_009'>65</span><span class='cls_010'>.</span></div>" +
"<div style='position:absolute;left:587.71px;top:334.55px' class='cls_010'><span class='cls_010'>OD</span></div>" +
"<div style='position:absolute;left:72.00px;top:353.39px' class='cls_010'><span class='cls_010'>Community acquired</span></div>" +
"<div style='position:absolute;left:204.98px;top:351.83px' class='cls_010'><span class='cls_010'>Give immediate IM Benzylpenicillin or oral amoxicillin</span></div>" +
"<div style='position:absolute;left:72.00px;top:364.91px' class='cls_010'><span class='cls_010'>pneumonia - treatment in</span></div>" +
"<div style='position:absolute;left:204.98px;top:363.35px' class='cls_010'><span class='cls_010'>(1G) or clarithromycin (500mg) in penicillin allergy if</span></div>" +
"<div style='position:absolute;left:72.00px;top:376.31px' class='cls_010'><span class='cls_010'>the community</span></div>" +
"<div style='position:absolute;left:204.98px;top:374.87px' class='cls_010'><span class='cls_010'>delayed admission or life threatening.</span></div>" +
"<div style='position:absolute;left:467.33px;top:399.59px' class='cls_010'><span class='cls_010'>If CRB65 score = 1 and</span></div>" +
"<div style='position:absolute;left:467.33px;top:411.11px' class='cls_010'><span class='cls_010'>patient at home</span></div>" +
"<div style='position:absolute;left:204.98px;top:418.07px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.nice.org.uk/guidance/cg191/chapter/1-recommendations'>NICE - Pneumonia</A></div>" +
"<div style='position:absolute;left:467.33px;top:422.63px' class='cls_010'><span class='cls_010'>Amoxicillin 500mg TDS</span></div>" +
"<div style='position:absolute;left:467.33px;top:434.15px' class='cls_010'><span class='cls_010'>plus Clarithromycin</span></div>" +
"<div style='position:absolute;left:708.34px;top:434.15px' class='cls_010'><span class='cls_010'>7 to 10 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:440.99px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/chest-infections-adult'>CKS - Pneumonia</A></div>" +
"<div style='position:absolute;left:467.33px;top:445.67px' class='cls_010'><span class='cls_010'>500mg BD or</span></div>" +
"<div style='position:absolute;left:467.33px;top:457.07px' class='cls_010'><span class='cls_010'>doxycycline 200mg stat</span></div>" +
"<div style='position:absolute;left:204.98px;top:464.06px' class='cls_040'><span class='cls_040'> </span><A HREF='https://www.brit-thoracic.org.uk/guidelines-and-quality-standards/community-acquired-pneumonia-in-adults-guideline/'>BTS - CAP</A></div>" +
"<div style='position:absolute;left:467.33px;top:468.62px' class='cls_010'><span class='cls_010'>then 100mg OD</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>21</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:13689px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background22.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:72.00px;top:122.22px' class='cls_023'><span class='cls_023'>MENINGITIS</span></div>" +
"<div style='position:absolute;left:204.98px;top:141.18px' class='cls_009'><span class='cls_009'>Transfer all patients to hospital immediately</span><span class='cls_010'>.</span></div>" +
"<div style='position:absolute;left:204.98px;top:152.82px' class='cls_010'><span class='cls_010'>NICE recommends that children and young people with</span></div>" +
"<div style='position:absolute;left:204.98px;top:164.10px' class='cls_010'><span class='cls_010'>suspected bacterial meningitis </span><span class='cls_028'>without </span><span class='cls_010'>non-blanching</span></div>" +
"<div style='position:absolute;left:204.98px;top:175.74px' class='cls_010'><span class='cls_010'>rash should be transferred directly to secondary care</span></div>" +
"<div style='position:absolute;left:204.98px;top:187.26px' class='cls_010'><span class='cls_010'>and not given parenteral antibiotics. If urgent transfer is</span></div>" +
"<div style='position:absolute;left:204.98px;top:198.81px' class='cls_010'><span class='cls_010'>not possible then antibiotics should be administered.</span></div>" +
"<div style='position:absolute;left:204.98px;top:221.85px' class='cls_010'><span class='cls_010'>For suspected meningococcal disease (meningitis with</span></div>" +
"<div style='position:absolute;left:587.71px;top:220.29px' class='cls_010'><span class='cls_010'>Withhold benzylpenicillin</span></div>" +
"<div style='position:absolute;left:467.33px;top:225.93px' class='cls_010'><span class='cls_010'>Adults and children</span></div>" +
"<div style='position:absolute;left:204.98px;top:233.25px' class='cls_010'><span class='cls_010'>non-blanching rash or meningococcal septicaemia),</span></div>" +
"<div style='position:absolute;left:587.71px;top:231.69px' class='cls_010'><span class='cls_010'>only in children and</span></div>" +
"<div style='position:absolute;left:467.33px;top:237.45px' class='cls_010'><span class='cls_010'>aged 10 years and over</span></div>" +
"<div style='position:absolute;left:204.98px;top:244.77px' class='cls_010'><span class='cls_010'>parenteral antibiotics should be given at the earliest</span></div>" +
"<div style='position:absolute;left:587.71px;top:243.21px' class='cls_010'><span class='cls_010'>young people who have</span></div>" +
"<div style='position:absolute;left:467.33px;top:248.97px' class='cls_010'><span class='cls_010'>Benzylpenicillin IV</span></div>" +
"<div style='position:absolute;left:72.00px;top:254.73px' class='cls_010'><span class='cls_010'>Suspected meningococcal</span></div>" +
"<div style='position:absolute;left:204.98px;top:256.29px' class='cls_010'><span class='cls_010'>opportunity but transfer to secondary care should not be</span></div>" +
"<div style='position:absolute;left:587.71px;top:254.73px' class='cls_010'><span class='cls_010'>a clear history of</span></div>" +
"<div style='position:absolute;left:467.33px;top:260.49px' class='cls_010'><span class='cls_010'>(preferable) or IM</span></div>" +
"<div style='position:absolute;left:72.00px;top:266.25px' class='cls_010'><span class='cls_010'>disease</span></div>" +
"<div style='position:absolute;left:204.98px;top:267.81px' class='cls_010'><span class='cls_010'>delayed in order to give the parenteral antibiotics.</span></div>" +
"<div style='position:absolute;left:587.71px;top:266.25px' class='cls_010'><span class='cls_010'>anaphylaxis after a</span></div>" +
"<div style='position:absolute;left:467.33px;top:272.01px' class='cls_010'><span class='cls_010'>1200mg, children aged</span></div>" +
"<div style='position:absolute;left:587.71px;top:277.77px' class='cls_010'><span class='cls_010'>previous dose; a history</span></div>" +
"<div style='position:absolute;left:467.33px;top:283.53px' class='cls_010'><span class='cls_010'>1 to 9 years 600mg,</span></div>" +
"<div style='position:absolute;left:204.98px;top:290.85px' class='cls_010'><span class='cls_010'>Secondary prevention should only be prescribed after</span></div>" +
"<div style='position:absolute;left:587.71px;top:289.17px' class='cls_010'><span class='cls_010'>of a rash following</span></div>" +
"<div style='position:absolute;left:467.33px;top:294.93px' class='cls_010'><span class='cls_010'>children aged under 1</span></div>" +
"<div style='position:absolute;left:204.98px;top:302.25px' class='cls_010'><span class='cls_010'>consulting a public health doctor</span></div>" +
"<div style='position:absolute;left:587.71px;top:300.69px' class='cls_010'><span class='cls_010'>penicillin is not a</span></div>" +
"<div style='position:absolute;left:467.33px;top:306.45px' class='cls_010'><span class='cls_010'>year 300mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:312.21px' class='cls_010'><span class='cls_010'>contraindication.</span></div>" +
"<div style='position:absolute;left:204.98px;top:327.71px' class='cls_040'><span class='cls_040'> </span><A HREF='https://www.gov.uk/government/collections/meningococcal-disease-guidance-data-and-analysis'>PHE - Meningococcal disease</A></div>" +
"<div style='position:absolute;left:204.98px;top:352.79px' class='cls_040'><span class='cls_040'> </span><A HREF='http://publications.nice.org.uk/bacterial-meningitis-and-meningococcal-septicaemia-cg102/guidance'>NICE - Meningococcal disease</A></div>" +
"<div style='position:absolute;left:204.98px;top:375.71px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/meningitis-bacterialmeningococcal-septicaemia#!background'>CKS - Meningitis</A></div>" +
"<div style='position:absolute;left:72.00px;top:402.71px' class='cls_023'><span class='cls_023'>URINARY TRACT INFECTIONS </span><span class='cls_027'>Nitrofurantoin is usually first line but is contraindicated if eGFR is &lt; 45ml/minute/1.73m</span><span class='cls_029'><sup>2</sup></span><span class='cls_027'> (but may be used for short courses</span></div>" +
"<div style='position:absolute;left:72.00px;top:414.35px' class='cls_027'><span class='cls_027'>of 3 to 7 days in patients with an eGFR</span><span class='cls_029'><sup> </sup></span><span class='cls_027'>of 30-44ml/minute). Advice on when to perform a urine dipstick test can be found </span><A HREF='https://www.gov.uk/government/uploads/system/uploads/attachment_data/file/345784/UTI_quick_ref_guidelines.pdf'>here.</A> </span></div>" +
"<div style='position:absolute;left:72.00px;top:429.11px' class='cls_010'><span class='cls_010'>UTI in women (all ages</span></div>" +
"<div style='position:absolute;left:204.98px;top:429.11px' class='cls_010'><span class='cls_010'>An antibiotic should be offered when symptoms are</span></div>" +
"<div style='position:absolute;left:587.71px;top:434.87px' class='cls_010'><span class='cls_010'>Trimethoprim 200mg BD</span></div>" +
"<div style='position:absolute;left:72.00px;top:440.63px' class='cls_010'><span class='cls_010'>from 14 years onwards)</span></div>" +
"<div style='position:absolute;left:204.98px;top:440.63px' class='cls_010'><span class='cls_010'>moderate or severe. Offer a 5 to 10 day course in</span></div>" +
"<div style='position:absolute;left:587.71px;top:446.39px' class='cls_010'><span class='cls_010'>or Pivmecillinam 400mg</span></div>" +
"<div style='position:absolute;left:72.00px;top:452.15px' class='cls_010'><span class='cls_010'>with no visible haematuria,</span></div>" +
"<div style='position:absolute;left:204.98px;top:452.15px' class='cls_010'><span class='cls_010'>women with impaired renal function, an abnormal urinary</span></div>" +
"<div style='position:absolute;left:467.33px;top:452.15px' class='cls_010'><span class='cls_010'>Nitrofurantoin 100mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:457.94px' class='cls_010'><span class='cls_010'>stat then 200mg TDS</span></div>" +
"<div style='position:absolute;left:708.34px;top:457.94px' class='cls_010'><span class='cls_010'>3 days.</span></div>" +
"<div style='position:absolute;left:72.00px;top:463.70px' class='cls_010'><span class='cls_010'>not pregnant or</span></div>" +
"<div style='position:absolute;left:204.98px;top:463.70px' class='cls_010'><span class='cls_010'>tract or immunosuppression such as poorly controlled</span></div>" +
"<div style='position:absolute;left:467.33px;top:463.70px' class='cls_010'><span class='cls_010'>BD (MR) or 50mg QDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:469.46px' class='cls_010'><span class='cls_010'>(where sensitivities</span></div>" +
"<div style='position:absolute;left:72.00px;top:475.22px' class='cls_010'><span class='cls_010'>catheterised</span></div>" +
"<div style='position:absolute;left:204.98px;top:475.22px' class='cls_010'><span class='cls_010'>diabetes. Send cultures for women who have impaired</span></div>" +
"<div style='position:absolute;left:587.71px;top:480.98px' class='cls_010'><span class='cls_010'>available)</span></div>" +
"<div style='position:absolute;left:204.98px;top:486.74px' class='cls_010'><span class='cls_010'>renal function, an abnormal urinary tract or are</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>22</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:14294px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background23.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>immunosuppressed. Do not send cultures for</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_010'><span class='cls_010'>uncomplicated UTI. If symptoms of a UTI persist</span></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_010'><span class='cls_010'>following treatment, send urine for culture and sensitivity</span></div>" +
"<div style='position:absolute;left:204.98px;top:149.82px' class='cls_010'><span class='cls_010'>and adjust treatment as necessary. If a multi-resistant</span></div>" +
"<div style='position:absolute;left:204.98px;top:161.22px' class='cls_010'><span class='cls_010'>organism is cultured, seek specialist advice as an</span></div>" +
"<div style='position:absolute;left:204.98px;top:172.74px' class='cls_010'><span class='cls_010'>increased incidence of UTIs caused by community multi-</span></div>" +
"<div style='position:absolute;left:204.98px;top:184.26px' class='cls_010'><span class='cls_010'>resistant ESBLs has been reported. Dipstick testing can</span></div>" +
"<div style='position:absolute;left:204.98px;top:195.81px' class='cls_010'><span class='cls_010'>be used to guide treatment in women &lt; 65 years with</span></div>" +
"<div style='position:absolute;left:204.98px;top:207.33px' class='cls_010'><span class='cls_010'>mild or ≤ 2 symptoms of UTI. Dipstick testing is</span></div>" +
"<div style='position:absolute;left:204.98px;top:218.85px' class='cls_010'><span class='cls_010'>unreliable in the > 65 year group and should be used</span></div>" +
"<div style='position:absolute;left:204.98px;top:230.25px' class='cls_010'><span class='cls_010'>with careful discretion to guide treatment decisions in</span></div>" +
"<div style='position:absolute;left:204.98px;top:241.77px' class='cls_010'><span class='cls_010'>otherwise healthy women over 65 years.</span></div>" +
"<div style='position:absolute;left:204.98px;top:265.29px' class='cls_040'><span class='cls_040'> </span><A HREF='https://www.gov.uk/government/collections/extended-spectrum-beta-lactamases-esbls-guidance-data-analysis'>PHE - ESBLs</A></div>" +
"<div style='position:absolute;left:204.98px;top:288.33px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/urinary-tract-infection-lower-women#!scenario'>CKS - UTI in women (lower)</A></div>" +
"<div style='position:absolute;left:204.98px;top:311.25px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.nice.org.uk/guidance/qs90'>NICE - Urinary tract infections in adults</A></div>" +
"<div style='position:absolute;left:204.98px;top:334.31px' class='cls_040'><span class='cls_040'>Treatment Algorithm - under 65</span></div>" +
"<div style='position:absolute;left:204.98px;top:357.35px' class='cls_025'><span class='cls_025'>Treatment Algorithm - over 65</span></div>" +
"<div style='position:absolute;left:204.98px;top:369.23px' class='cls_009'><span class='cls_009'>MSU should always be taken to confirm sensitivity</span><span class='cls_010'>.</span></div>" +
"<div style='position:absolute;left:204.98px;top:380.75px' class='cls_010'><span class='cls_010'>Offer a 5 to 10 day course in women with impaired renal</span></div>" +
"<div style='position:absolute;left:204.98px;top:392.27px' class='cls_010'><span class='cls_010'>function, an abnormal urinary tract or</span></div>" +
"<div style='position:absolute;left:204.98px;top:403.79px' class='cls_010'><span class='cls_010'>immunosuppression such as poorly controlled diabetes.</span></div>" +
"<div style='position:absolute;left:587.71px;top:404.03px' class='cls_010'><span class='cls_010'>Trimethoprim 200mg BD</span></div>" +
"<div style='position:absolute;left:72.00px;top:409.79px' class='cls_010'><span class='cls_010'>UTI in women (all ages</span></div>" +
"<div style='position:absolute;left:204.98px;top:415.31px' class='cls_010'><span class='cls_010'>If a multi-resistant organism is cultured, seek specialist</span></div>" +
"<div style='position:absolute;left:587.71px;top:415.55px' class='cls_010'><span class='cls_010'>or Pivmecillinam 400mg</span></div>" +
"<div style='position:absolute;left:72.00px;top:421.31px' class='cls_010'><span class='cls_010'>from 14 years onwards)</span></div>" +
"<div style='position:absolute;left:467.33px;top:421.31px' class='cls_010'><span class='cls_010'>Nitrofurantoin 100mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:426.83px' class='cls_010'><span class='cls_010'>advice as an increased incidence of UTIs caused by</span></div>" +
"<div style='position:absolute;left:587.71px;top:427.07px' class='cls_010'><span class='cls_010'>stat then 200mg TDS</span></div>" +
"<div style='position:absolute;left:708.34px;top:427.07px' class='cls_010'><span class='cls_010'>3 days</span></div>" +
"<div style='position:absolute;left:72.00px;top:432.83px' class='cls_010'><span class='cls_010'>with haematuria and not</span></div>" +
"<div style='position:absolute;left:467.33px;top:432.83px' class='cls_010'><span class='cls_010'>BD (MR) or 50mg QDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:438.35px' class='cls_010'><span class='cls_010'>community multi-resistant ESBLs has been reported.</span></div>" +
"<div style='position:absolute;left:587.71px;top:438.59px' class='cls_010'><span class='cls_010'>(where sensitivities</span></div>" +
"<div style='position:absolute;left:72.00px;top:444.35px' class='cls_010'><span class='cls_010'>pregnant</span></div>" +
"<div style='position:absolute;left:204.98px;top:450.35px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/urinary-tract-infection-lower-women#!scenario:1'>CKS - UTI visible or non visible haematuria</A></div>" +
"<div style='position:absolute;left:587.71px;top:450.11px' class='cls_010'><span class='cls_010'>available)</span></div>" +
"<div style='position:absolute;left:204.98px;top:473.30px' class='cls_040'><span class='cls_040'> </span><A HREF='https://www.gov.uk/government/collections/extended-spectrum-beta-lactamases-esbls-guidance-data-analysis'>PHE - ESBLs</A></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>23</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:14899px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background24.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_040'><span class='cls_040'> </span><A HREF='https://www.nice.org.uk/advice/ktt10'>NICE - 3 day UTI course</A></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_025'><span class='cls_025'> </span><A HREF='http://www.nice.org.uk/guidance/qs90'>NICE - Urinary tract infections in adults</A></div>" +
"<div style='position:absolute;left:204.98px;top:150.18px' class='cls_009'><span class='cls_009'>MSU should always be taken to confirm sensitivity.</span></div>" +
"<div style='position:absolute;left:204.98px;top:161.70px' class='cls_009'><span class='cls_009'>Do not use dipstick testing to screen for bacterial</span></div>" +
"<div style='position:absolute;left:204.98px;top:173.10px' class='cls_009'><span class='cls_009'>UTI at any antenatal visit. </span><span class='cls_010'>A further MSU should be</span></div>" +
"<div style='position:absolute;left:204.98px;top:184.74px' class='cls_010'><span class='cls_010'>sent 7 days after treatment has finished as a test of</span></div>" +
"<div style='position:absolute;left:204.98px;top:196.29px' class='cls_010'><span class='cls_010'>cure. If treating with trimethoprim, give folic acid 5mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:207.81px' class='cls_010'><span class='cls_010'>daily during first trimester and do not give trimethoprim if</span></div>" +
"<div style='position:absolute;left:204.98px;top:219.33px' class='cls_010'><span class='cls_010'>folate deficiency is suspected or woman is taking a</span></div>" +
"<div style='position:absolute;left:204.98px;top:230.85px' class='cls_010'><span class='cls_010'>folate antagonist. Do not use nitrofurantoin in women</span></div>" +
"<div style='position:absolute;left:204.98px;top:242.25px' class='cls_010'><span class='cls_010'>who are G6PD deficient. Short term use of nitrofurantoin</span></div>" +
"<div style='position:absolute;left:204.98px;top:253.53px' class='cls_010'><span class='cls_010'>is unlikely to cause problems to the foetus. Cefalexin</span><span class='cls_016'>♣</span><span class='cls_010'> is</span></div>" +
"<div style='position:absolute;left:587.71px;top:255.21px' class='cls_010'><span class='cls_010'>Trimethoprim 200mg BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:267.57px' class='cls_010'><span class='cls_010'>less preferred due to concerns that broad spectrum</span></div>" +
"<div style='position:absolute;left:467.33px;top:266.73px' class='cls_010'><span class='cls_010'>Nitrofurantoin 50mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:266.73px' class='cls_010'><span class='cls_010'>(off label use) or</span></div>" +
"<div style='position:absolute;left:72.00px;top:272.49px' class='cls_010'><span class='cls_010'>UTI in pregnancy</span></div>" +
"<div style='position:absolute;left:708.34px;top:272.49px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:278.97px' class='cls_010'><span class='cls_010'>antibiotics increase the risk of </span><span class='cls_028'>Clostridium difficile</span><span class='cls_010'> which</span></div>" +
"<div style='position:absolute;left:467.33px;top:278.25px' class='cls_010'><span class='cls_010'>QDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:278.25px' class='cls_010'><span class='cls_010'>Cefalexin</span><span class='cls_011'>♣</span><span class='cls_010'> 500mg BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:290.61px' class='cls_010'><span class='cls_010'>can be life threatening in pregnant women and also</span></div>" +
"<div style='position:absolute;left:587.71px;top:289.65px' class='cls_010'><span class='cls_010'>(less preferred)</span></div>" +
"<div style='position:absolute;left:204.98px;top:302.13px' class='cls_010'><span class='cls_010'>because of the risk of resistant UTIs. Amoxicillin is only</span></div>" +
"<div style='position:absolute;left:204.98px;top:313.65px' class='cls_010'><span class='cls_010'>recommended if the organism is susceptible as</span></div>" +
"<div style='position:absolute;left:204.98px;top:325.07px' class='cls_010'><span class='cls_010'>resistance is common.</span></div>" +
"<div style='position:absolute;left:204.98px;top:337.07px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/urinary-tract-infection-lower-women'>CKS - UTI in pregnancy</A></div>" +
"<div style='position:absolute;left:204.98px;top:360.11px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/urinary-tract-infection-lower-women#!scenario:1'>CKS - UTI visible or non visible haematuria</A></div>" +
"<div style='position:absolute;left:204.98px;top:383.15px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.sign.ac.uk/pdf/sign88.pdf'>SIGN - UTI guidelines</A></div>" +
"<div style='position:absolute;left:204.98px;top:406.55px' class='cls_010'><span class='cls_010'>Screen for asymptomatic bacteriuria at the first antenatal</span></div>" +
"<div style='position:absolute;left:204.98px;top:418.07px' class='cls_010'><span class='cls_010'>visit by sending urine for culture. If asymptomatic</span></div>" +
"<div style='position:absolute;left:587.71px;top:416.99px' class='cls_010'><span class='cls_010'>Nitrofurantoin 100mg</span></div>" +
"<div style='position:absolute;left:72.00px;top:429.59px' class='cls_010'><span class='cls_010'>Asymptomatic bacteriuria</span></div>" +
"<div style='position:absolute;left:204.98px;top:429.59px' class='cls_010'><span class='cls_010'>bacteriuria is found, send a second sample for culture</span></div>" +
"<div style='position:absolute;left:587.71px;top:428.51px' class='cls_010'><span class='cls_010'>MR BD or 50mg QDS or</span></div>" +
"<div style='position:absolute;left:72.00px;top:441.11px' class='cls_010'><span class='cls_010'>in pregnancy (only treat</span></div>" +
"<div style='position:absolute;left:204.98px;top:441.11px' class='cls_010'><span class='cls_010'>and repeat urine culture at each antenatal visit until</span></div>" +
"<div style='position:absolute;left:467.33px;top:441.11px' class='cls_010'><span class='cls_010'>Amoxicillin 500mg TDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:439.91px' class='cls_010'><span class='cls_010'>Trimethoprim 200mg BD</span></div>" +
"<div style='position:absolute;left:708.34px;top:446.87px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:72.00px;top:452.63px' class='cls_010'><span class='cls_010'>when sensitivities are</span></div>" +
"<div style='position:absolute;left:204.98px;top:452.63px' class='cls_010'><span class='cls_010'>delivery. If the second sample confirms asymptomatic</span></div>" +
"<div style='position:absolute;left:587.71px;top:451.43px' class='cls_010'><span class='cls_010'>(off label use) or</span></div>" +
"<div style='position:absolute;left:72.00px;top:464.18px' class='cls_010'><span class='cls_010'>known)</span></div>" +
"<div style='position:absolute;left:204.98px;top:464.18px' class='cls_010'><span class='cls_010'>bacteriuria, treat with an antibiotic. If treating with</span></div>" +
"<div style='position:absolute;left:587.71px;top:462.74px' class='cls_010'><span class='cls_010'>Cefalexin</span><span class='cls_016'>♣</span><span class='cls_010'> 500mg BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:475.58px' class='cls_010'><span class='cls_010'>trimethoprim, give folic acid 5mg daily during first</span></div>" +
"<div style='position:absolute;left:587.71px;top:476.78px' class='cls_010'><span class='cls_010'>(less preferred)</span></div>" +
"<div style='position:absolute;left:204.98px;top:487.10px' class='cls_010'><span class='cls_010'>trimester and do not give trimethoprim if the woman is</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>24</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:15504px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background25.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>folate deficient, taking a folate antagonist or has taken</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_010'><span class='cls_010'>trimethoprim within the last year. Do not use</span></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_010'><span class='cls_010'>nitrofurantoin in women who are G6PD deficient or are</span></div>" +
"<div style='position:absolute;left:204.98px;top:149.58px' class='cls_010'><span class='cls_010'>near to term. Cefalexin</span><span class='cls_016'>♣</span><span class='cls_010'> is less preferred due to</span></div>" +
"<div style='position:absolute;left:204.98px;top:163.62px' class='cls_010'><span class='cls_010'>concerns that broad spectrum antibiotics increase the</span></div>" +
"<div style='position:absolute;left:204.98px;top:174.90px' class='cls_010'><span class='cls_010'>risk of </span><span class='cls_028'>Clostridium difficile</span><span class='cls_010'> which can be life threatening</span></div>" +
"<div style='position:absolute;left:204.98px;top:186.54px' class='cls_010'><span class='cls_010'>in pregnant women and also because of the risk of</span></div>" +
"<div style='position:absolute;left:204.98px;top:198.09px' class='cls_010'><span class='cls_010'>resistant UTIs.</span></div>" +
"<div style='position:absolute;left:204.98px;top:210.09px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/urinary-tract-infection-lower-women#!scenario:4'>CKS - Asymptomatic bacteriuria in pregnancy</A></div>" +
"<div style='position:absolute;left:204.98px;top:233.13px' class='cls_025'><span class='cls_025'> </span><A HREF='http://www.sign.ac.uk/pdf/sign88.pdf'>SIGN - UTI guidelines</A></div>" +
"<div style='position:absolute;left:72.00px;top:245.01px' class='cls_010'><span class='cls_010'>Catheter in situ: </span><span class='cls_009'>Antibiotics will not eradicate asymptomatic bacteriuria. </span><span class='cls_010'>Only treat if patient is systemically unwell or pyelonephritis is suspected. Do not</span></div>" +
"<div style='position:absolute;left:72.00px;top:256.65px' class='cls_010'><span class='cls_010'>use prophylactic antibiotics for change of catheter unless history of catheter associated UTI or trauma. </span><A HREF='https://www.gov.uk/government/uploads/system/uploads/attachment_data/file/377509/PHE_Primary_Care_guidance_14_11_14.pdf'>PHE - Management of Infection Guidance for primary</A> </span></div>" +
"<div style='position:absolute;left:72.00px;top:268.05px' class='cls_025'><span class='cls_025'> </span><A HREF='https://www.gov.uk/government/uploads/system/uploads/attachment_data/file/377509/PHE_Primary_Care_guidance_14_11_14.pdf'>care</A></div>" +
"<div style='position:absolute;left:204.98px;top:279.93px' class='cls_009'><span class='cls_009'>CSU should always be taken to confirm sensitivity.</span></div>" +
"<div style='position:absolute;left:204.98px;top:291.45px' class='cls_009'><span class='cls_009'>NEVER use dipstick testing to diagnose UTI in</span></div>" +
"<div style='position:absolute;left:204.98px;top:302.97px' class='cls_009'><span class='cls_009'>catheterised patients. </span><span class='cls_010'>Change long term indwelling</span></div>" +
"<div style='position:absolute;left:204.98px;top:314.61px' class='cls_010'><span class='cls_010'>catheters before starting antibiotic treatment. Measures</span></div>" +
"<div style='position:absolute;left:204.98px;top:326.15px' class='cls_010'><span class='cls_010'>to prevent UTI in patients with catheters include review</span></div>" +
"<div style='position:absolute;left:204.98px;top:337.67px' class='cls_010'><span class='cls_010'>of need for catheter, prevention of infection and</span></div>" +
"<div style='position:absolute;left:204.98px;top:348.95px' class='cls_010'><span class='cls_010'>awareness of measures which </span><span class='cls_009'>shouldn’t</span><span class='cls_010'> be used such</span></div>" +
"<div style='position:absolute;left:204.98px;top:360.59px' class='cls_010'><span class='cls_010'>as prophylactic antibiotics, bladder installations and</span></div>" +
"<div style='position:absolute;left:204.98px;top:372.11px' class='cls_010'><span class='cls_010'>washouts and topical antibiotics or antiseptics applied</span></div>" +
"<div style='position:absolute;left:587.71px;top:378.11px' class='cls_010'><span class='cls_010'>Nitrofurantoin 100mg</span></div>" +
"<div style='position:absolute;left:72.00px;top:383.87px' class='cls_010'><span class='cls_010'>UTI with catheter</span></div>" +
"<div style='position:absolute;left:204.98px;top:383.63px' class='cls_010'><span class='cls_010'>directly to the catheter, urethra or meatus. Daily washing</span></div>" +
"<div style='position:absolute;left:467.33px;top:383.87px' class='cls_010'><span class='cls_010'>Trimethoprim 200mg BD</span></div>" +
"<div style='position:absolute;left:708.34px;top:383.87px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:389.63px' class='cls_010'><span class='cls_010'>BD MR or 50mg QDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:395.15px' class='cls_010'><span class='cls_010'>of the meatus with soap and water is sufficient.</span></div>" +
"<div style='position:absolute;left:204.98px;top:407.15px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/urinary-tract-infection-lower-women#!scenario:5'>CKS - UTI with catheter - no haematuria - women</A></div>" +
"<div style='position:absolute;left:204.98px;top:430.07px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/urinary-tract-infection-lower-men#!scenario:2'>CKS - UTI in men with an indwelling catheter</A></div>" +
"<div style='position:absolute;left:204.98px;top:453.11px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.sign.ac.uk/pdf/sign88.pdf'>SIGN - UTI guidance</A></div>" +
"<div style='position:absolute;left:204.98px;top:476.18px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.nice.org.uk/guidance/qs90'>NICE - Urinary tract infections in adults</A></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>25</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:16109px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background26.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:116.46px' class='cls_009'><span class='cls_009'>MSU should always be taken to confirm sensitivity.</span></div>" +
"<div style='position:absolute;left:204.98px;top:127.98px' class='cls_010'><span class='cls_010'>Consider prostatitis.</span></div>" +
"<div style='position:absolute;left:587.71px;top:133.98px' class='cls_010'><span class='cls_010'>Nitrofurantoin 100mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:141.30px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/urinary-tract-infection-lower-men'>CKS - UTI in men</A></div>" +
"<div style='position:absolute;left:587.71px;top:145.50px' class='cls_010'><span class='cls_010'>BD (MR) or 50mg QDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:157.02px' class='cls_010'><span class='cls_010'>or Pivmecillinam 400mg</span></div>" +
"<div style='position:absolute;left:72.00px;top:162.78px' class='cls_010'><span class='cls_010'>UTI in men</span></div>" +
"<div style='position:absolute;left:204.98px;top:164.22px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.nice.org.uk/guidance/qs90'>NICE - Urinary tract infections in adults</A></div>" +
"<div style='position:absolute;left:467.33px;top:162.78px' class='cls_010'><span class='cls_010'>Trimethoprim 200mg BD</span></div>" +
"<div style='position:absolute;left:708.34px;top:162.78px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:168.54px' class='cls_010'><span class='cls_010'>stat then 200mg TDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:180.06px' class='cls_010'><span class='cls_010'>(where sensitivities</span></div>" +
"<div style='position:absolute;left:204.98px;top:187.26px' class='cls_040'><span class='cls_040'>Treatment Algorithm - under 65</span></div>" +
"<div style='position:absolute;left:587.71px;top:191.61px' class='cls_010'><span class='cls_010'>available)</span></div>" +
"<div style='position:absolute;left:204.98px;top:210.33px' class='cls_025'><span class='cls_025'>Treatment Algorithm - over 65</span></div>" +
"<div style='position:absolute;left:204.98px;top:222.33px' class='cls_041'><span class='cls_041'>Children &lt; 3 months</span><span class='cls_010'> - Refer for emergency assessment</span></div>" +
"<div style='position:absolute;left:204.98px;top:233.85px' class='cls_010'><span class='cls_010'>but do not take an MSU as this will not alter</span></div>" +
"<div style='position:absolute;left:204.98px;top:245.25px' class='cls_010'><span class='cls_010'>management in primary care.</span></div>" +
"<div style='position:absolute;left:204.98px;top:256.77px' class='cls_041'><span class='cls_041'>Children 3 months to 3 years - </span><span class='cls_010'> Urgently refer those</span></div>" +
"<div style='position:absolute;left:204.98px;top:268.29px' class='cls_010'><span class='cls_010'>children at high risk for serious illness and consider</span></div>" +
"<div style='position:absolute;left:204.98px;top:279.81px' class='cls_010'><span class='cls_010'>referring those at intermediate risk for serious illness.</span></div>" +
"<div style='position:absolute;left:587.71px;top:288.57px' class='cls_010'><span class='cls_010'>Nitrofurantoin (see BNF</span></div>" +
"<div style='position:absolute;left:204.98px;top:291.33px' class='cls_010'><span class='cls_010'>For all other children, treat with antibiotics whilst</span></div>" +
"<div style='position:absolute;left:204.98px;top:302.85px' class='cls_010'><span class='cls_010'>awaiting results of urine culture.</span></div>" +
"<div style='position:absolute;left:587.71px;top:300.09px' class='cls_010'><span class='cls_010'>for children for doses) or</span></div>" +
"<div style='position:absolute;left:72.00px;top:305.85px' class='cls_010'><span class='cls_010'>UTI in children ( ≤ 16</span></div>" +
"<div style='position:absolute;left:467.33px;top:305.85px' class='cls_010'><span class='cls_010'>Trimethoprim (see BNF</span></div>" +
"<div style='position:absolute;left:587.71px;top:311.49px' class='cls_010'><span class='cls_010'>Co-amoxiclav</span><span class='cls_011'>♣</span><span class='cls_010'> (for</span></div>" +
"<div style='position:absolute;left:708.34px;top:311.49px' class='cls_010'><span class='cls_010'>3 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:314.25px' class='cls_041'><span class='cls_041'>Children over 3 years</span><span class='cls_010'> -  Urgently refer those children at</span></div>" +
"<div style='position:absolute;left:72.00px;top:317.25px' class='cls_010'><span class='cls_010'>years)</span></div>" +
"<div style='position:absolute;left:467.33px;top:317.25px' class='cls_010'><span class='cls_010'>for children for doses)</span></div>" +
"<div style='position:absolute;left:587.71px;top:323.01px' class='cls_010'><span class='cls_010'>upper UTI and treat for</span></div>" +
"<div style='position:absolute;left:204.98px;top:325.79px' class='cls_010'><span class='cls_010'>high risk for serious illness and consider referring those</span></div>" +
"<div style='position:absolute;left:587.71px;top:334.55px' class='cls_010'><span class='cls_010'>7-10 days)</span></div>" +
"<div style='position:absolute;left:204.98px;top:337.31px' class='cls_010'><span class='cls_010'>at intermediate risk for serious illness. For all other</span></div>" +
"<div style='position:absolute;left:204.98px;top:348.83px' class='cls_010'><span class='cls_010'>children, send an MSU before treating with an antibiotic.</span></div>" +
"<div style='position:absolute;left:204.98px;top:369.35px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/urinary-tract-infection-children'>CKS - UTI in children</A></div>" +
"<div style='position:absolute;left:204.98px;top:392.27px' class='cls_040'><span class='cls_040'> </span><A HREF='http://guidance.nice.org.uk/CG54/QuickRefGuide/pdf/English'>NICE - Urinary tract infection in children</A></div>" +
"<div style='position:absolute;left:204.98px;top:412.79px' class='cls_010'><span class='cls_010'>Consider prophylactic treatment when there is</span></div>" +
"<div style='position:absolute;left:204.98px;top:424.31px' class='cls_010'><span class='cls_010'>unacceptable discomfort or disruption to daily life. Offer</span></div>" +
"<div style='position:absolute;left:72.00px;top:435.83px' class='cls_010'><span class='cls_010'>UTI - recurrent (≥ 3 per</span></div>" +
"<div style='position:absolute;left:204.98px;top:435.83px' class='cls_010'><span class='cls_010'>a script for stand-by treatment before considering</span></div>" +
"<div style='position:absolute;left:467.33px;top:441.59px' class='cls_010'><span class='cls_010'>Trimethoprim 100mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:441.59px' class='cls_010'><span class='cls_010'>Nitrofurantoin 50mg to</span></div>" +
"<div style='position:absolute;left:72.00px;top:447.35px' class='cls_010'><span class='cls_010'>year) in non-pregnant</span></div>" +
"<div style='position:absolute;left:204.98px;top:447.35px' class='cls_010'><span class='cls_010'>prophylactic antibiotics. Use a STAT dose of</span></div>" +
"<div style='position:absolute;left:708.34px;top:447.35px' class='cls_010'><span class='cls_010'>6 month trial</span></div>" +
"<div style='position:absolute;left:467.33px;top:453.11px' class='cls_010'><span class='cls_010'>nocte</span></div>" +
"<div style='position:absolute;left:587.71px;top:453.11px' class='cls_010'><span class='cls_010'>100mg nocte</span></div>" +
"<div style='position:absolute;left:72.00px;top:458.78px' class='cls_010'><span class='cls_010'>women over 14 years</span></div>" +
"<div style='position:absolute;left:204.98px;top:458.78px' class='cls_010'><span class='cls_010'>trimethoprim 100mg post coital if recurrent infection is</span></div>" +
"<div style='position:absolute;left:204.98px;top:470.30px' class='cls_010'><span class='cls_010'>associated with sexual intercourse (off label use and</span></div>" +
"<div style='position:absolute;left:204.98px;top:481.82px' class='cls_010'><span class='cls_010'>within 2 hours of sexual intercourse). Use a nightly</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>26</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:16714px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background27.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>prophylactic dose for recurrent infection NOT associated</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_010'><span class='cls_010'>with sexual intercourse. Long term use of nitrofurantoin</span></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_010'><span class='cls_010'>is not advisable as it can cause pulmonary fibrosis,</span></div>" +
"<div style='position:absolute;left:204.98px;top:149.82px' class='cls_010'><span class='cls_010'>hepatic problems and peripheral neuropathy.</span></div>" +
"<div style='position:absolute;left:204.98px;top:168.78px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/urinary-tract-infection-lower-women'>CKS - UTI recurrent</A></div>" +
"<div style='position:absolute;left:467.33px;top:189.06px' class='cls_010'><span class='cls_010'>Ciprofloxacin</span><span class='cls_011'>♣</span><span class='cls_010'> 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:196.17px' class='cls_009'><span class='cls_009'>MSU should always be taken to confirm sensitivity</span><span class='cls_010'>. If</span></div>" +
"<div style='position:absolute;left:708.34px;top:194.85px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:200.61px' class='cls_010'><span class='cls_010'>BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:207.81px' class='cls_010'><span class='cls_010'>no response within 24 hours or there is clinical</span></div>" +
"<div style='position:absolute;left:204.98px;top:219.33px' class='cls_010'><span class='cls_010'>deterioration, arrange for admission.</span></div>" +
"<div style='position:absolute;left:587.71px;top:228.09px' class='cls_010'><span class='cls_010'>Co-amoxiclav</span><span class='cls_011'>♣</span><span class='cls_010'> 625mg</span></div>" +
"<div style='position:absolute;left:708.34px;top:233.85px' class='cls_010'><span class='cls_010'>14 days</span></div>" +
"<div style='position:absolute;left:72.00px;top:237.57px' class='cls_010'><span class='cls_010'>Pyelonephritis (acute)</span></div>" +
"<div style='position:absolute;left:587.71px;top:239.61px' class='cls_010'><span class='cls_010'>TDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:263.61px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/pyelonephritis-acute'>CKS - Pyelonephritis</A></div>" +
"<div style='position:absolute;left:587.71px;top:275.85px' class='cls_041'><span class='cls_041'>For pregnant women</span></div>" +
"<div style='position:absolute;left:708.34px;top:276.57px' class='cls_010'><span class='cls_010'>10 to 14 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:287.25px' class='cls_010'><span class='cls_010'>Cefalexin</span><span class='cls_011'>♣</span><span class='cls_010'> 500mg BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:309.21px' class='cls_009'><span class='cls_009'>MSU should always be taken to confirm sensitivity.</span></div>" +
"<div style='position:absolute;left:204.98px;top:320.85px' class='cls_010'><span class='cls_010'>4 weeks treatment may prevent chronic infection.</span></div>" +
"<div style='position:absolute;left:204.98px;top:332.27px' class='cls_010'><span class='cls_010'>Quinolones</span><span class='cls_011'>♣</span><span class='cls_010'> are more effective as they achieve higher</span></div>" +
"<div style='position:absolute;left:204.98px;top:343.79px' class='cls_010'><span class='cls_010'>prostate levels. If patient is sexually active, chlamydia</span></div>" +
"<div style='position:absolute;left:467.33px;top:351.23px' class='cls_010'><span class='cls_010'>Ciprofloxacin</span><span class='cls_011'>♣</span><span class='cls_010'> 500mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:351.23px' class='cls_010'><span class='cls_010'>Trimethoprim 200mg BD</span></div>" +
"<div style='position:absolute;left:72.00px;top:356.99px' class='cls_010'><span class='cls_010'>Prostatitis (acute)</span></div>" +
"<div style='position:absolute;left:204.98px;top:355.31px' class='cls_010'><span class='cls_010'>needs to be excluded</span></div>" +
"<div style='position:absolute;left:708.34px;top:356.99px' class='cls_010'><span class='cls_010'>4 weeks</span></div>" +
"<div style='position:absolute;left:467.33px;top:362.75px' class='cls_010'><span class='cls_010'>BD</span></div>" +
"<div style='position:absolute;left:587.71px;top:362.75px' class='cls_010'><span class='cls_010'>(off label use)</span></div>" +
"<div style='position:absolute;left:204.98px;top:379.43px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/prostatitis-acute'>CKS - Prostatitis</A></div>" +
"<div style='position:absolute;left:204.98px;top:402.47px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.bashh.org/guidelines'>BASHH - Prostatitis</A></div>" +
"<div style='position:absolute;left:72.00px;top:433.55px' class='cls_023'><span class='cls_023'>GASTRO-INTESTINAL TRACT INFECTIONS</span></div>" +
"<div style='position:absolute;left:204.98px;top:452.51px' class='cls_009'><span class='cls_009'>Antibiotics are not recommended for adults with diarrhoea of unknown pathology</span><span class='cls_010'>. Evidence from 3 small randomised</span></div>" +
"<div style='position:absolute;left:204.98px;top:464.18px' class='cls_010'><span class='cls_010'>controlled trials (RCTs) suggests they have minimal benefits, there is a risk of serious adverse effects associated with their use</span></div>" +
"<div style='position:absolute;left:72.00px;top:469.94px' class='cls_010'><span class='cls_010'>Gastro-enteritis</span></div>" +
"<div style='position:absolute;left:204.98px;top:473.66px' class='cls_010'><span class='cls_010'>and their use promotes the development of resistant bacteria.  Fluid replacement is essential and check travel, food, hospital</span></div>" +
"<div style='position:absolute;left:204.98px;top:486.98px' class='cls_010'><span class='cls_010'>and antibiotic history as </span><span class='cls_028'>C. difficile</span><span class='cls_010'> is increasing. Please send stool specimens from suspected cases of food poisoning and</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>27</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:17319px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background28.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>post antibiotic use and notify Public Health England after seeking advice from a public health doctor if an outbreak is</span></div>" +
"<div style='position:absolute;left:204.98px;top:124.74px' class='cls_010'><span class='cls_010'>suspected.</span><span class='cls_002'> </span><A HREF='http://cks.nice.org.uk/gastroenteritis'>CKS - Gastroenteritis CKS - Travellers’ diarrhoea prevention and advice</A> </span></div>" +
"<div style='position:absolute;left:204.98px;top:141.30px' class='cls_010'><span class='cls_010'>When prescribing an antibiotic for </span><span class='cls_041'>any indication</span><span class='cls_010'> in</span></div>" +
"<div style='position:absolute;left:587.71px;top:141.66px' class='cls_010'><span class='cls_010'>Vancomycin 125mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:152.70px' class='cls_010'><span class='cls_010'>patients who have had a previous </span><span class='cls_028'>Clostridium difficile</span></div>" +
"<div style='position:absolute;left:587.71px;top:151.50px' class='cls_010'><span class='cls_010'>QDS (3</span><span class='cls_030'><sup>rd</sup></span><span class='cls_010'> episode or if</span></div>" +
"<div style='position:absolute;left:204.98px;top:164.22px' class='cls_010'><span class='cls_010'>infection, advice should be sought from a microbiologist</span></div>" +
"<div style='position:absolute;left:587.71px;top:164.58px' class='cls_010'><span class='cls_010'>severe or if type 027</span></div>" +
"<div style='position:absolute;left:204.98px;top:175.74px' class='cls_010'><span class='cls_010'>to avoid any potential relapse. Stop all antibiotics unless</span></div>" +
"<div style='position:absolute;left:587.71px;top:176.10px' class='cls_010'><span class='cls_010'>confirmed). Fidaxomicin</span></div>" +
"<div style='position:absolute;left:204.98px;top:187.26px' class='cls_010'><span class='cls_010'>it is absolutely essential that they are continued in which</span></div>" +
"<div style='position:absolute;left:467.33px;top:187.62px' class='cls_010'><span class='cls_010'>Metronidazole 400mg to</span></div>" +
"<div style='position:absolute;left:587.71px;top:187.62px' class='cls_010'><span class='cls_010'>200mg BD should be</span></div>" +
"<div style='position:absolute;left:72.00px;top:193.29px' class='cls_028'><span class='cls_028'>Clostridium difficile</span></div>" +
"<div style='position:absolute;left:204.98px;top:198.81px' class='cls_010'><span class='cls_010'>case the patient should be carefully monitored for</span></div>" +
"<div style='position:absolute;left:467.33px;top:197.61px' class='cls_010'><span class='cls_010'>500mg TDS (1</span><span class='cls_030'><sup>st</sup></span><span class='cls_010'>/2</span><span class='cls_030'><sup>nd</sup></span></div>" +
"<div style='position:absolute;left:587.71px;top:199.17px' class='cls_010'><span class='cls_010'>considered for patients</span></div>" +
"<div style='position:absolute;left:708.34px;top:199.17px' class='cls_010'><span class='cls_010'>10 - 14 days</span></div>" +
"<div style='position:absolute;left:72.00px;top:204.93px' class='cls_010'><span class='cls_010'>Infection (CDI)</span></div>" +
"<div style='position:absolute;left:204.98px;top:210.33px' class='cls_010'><span class='cls_010'>deterioration (consider hospital admission in these</span></div>" +
"<div style='position:absolute;left:467.33px;top:210.69px' class='cls_010'><span class='cls_010'>episodes)</span></div>" +
"<div style='position:absolute;left:587.71px;top:210.69px' class='cls_010'><span class='cls_010'>with severe CDI who are</span></div>" +
"<div style='position:absolute;left:204.98px;top:221.85px' class='cls_010'><span class='cls_010'>circumstances) and review need for PPI therapy.</span></div>" +
"<div style='position:absolute;left:587.71px;top:222.09px' class='cls_010'><span class='cls_010'>considered at high risk</span></div>" +
"<div style='position:absolute;left:587.71px;top:233.61px' class='cls_010'><span class='cls_010'>for recurrence, only after</span></div>" +
"<div style='position:absolute;left:204.98px;top:245.25px' class='cls_040'><span class='cls_040'>PHE - </span><span class='cls_042'>Clostridium difficile</span></div>" +
"<div style='position:absolute;left:587.71px;top:245.13px' class='cls_010'><span class='cls_010'>discussion  with a</span></div>" +
"<div style='position:absolute;left:587.71px;top:256.65px' class='cls_010'><span class='cls_010'>microbiologist</span></div>" +
"<div style='position:absolute;left:204.98px;top:269.01px' class='cls_010'><span class='cls_010'>Discuss management with a consultant microbiologist</span></div>" +
"<div style='position:absolute;left:204.98px;top:280.41px' class='cls_010'><span class='cls_010'>for advice on sending specimens and treatment options.</span></div>" +
"<div style='position:absolute;left:204.98px;top:291.93px' class='cls_010'><span class='cls_010'>Sending repeat specimens within 28 days of a positive</span></div>" +
"<div style='position:absolute;left:204.98px;top:303.45px' class='cls_010'><span class='cls_010'>test are not helpful due to ongoing presence of toxins in</span></div>" +
"<div style='position:absolute;left:204.98px;top:314.97px' class='cls_010'><span class='cls_010'>the gut. Recurrent disease occurs in about 20% of</span></div>" +
"<div style='position:absolute;left:467.33px;top:316.41px' class='cls_010'><span class='cls_010'>Fidaxomicin 200mg BD</span></div>" +
"<div style='position:absolute;left:587.71px;top:322.17px' class='cls_010'><span class='cls_010'>Vancomycin 125mg</span></div>" +
"<div style='position:absolute;left:72.00px;top:327.95px' class='cls_010'><span class='cls_010'>CDI recurrence</span></div>" +
"<div style='position:absolute;left:204.98px;top:326.51px' class='cls_010'><span class='cls_010'>patients treated initially with either metronidazole or</span></div>" +
"<div style='position:absolute;left:467.33px;top:327.95px' class='cls_010'><span class='cls_010'>(discuss with</span></div>" +
"<div style='position:absolute;left:708.34px;top:327.95px' class='cls_010'><span class='cls_010'>14 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:333.71px' class='cls_010'><span class='cls_010'>QDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:337.91px' class='cls_010'><span class='cls_010'>vancomycin. The same antibiotic that was used initially</span></div>" +
"<div style='position:absolute;left:467.33px;top:339.47px' class='cls_010'><span class='cls_010'>microbiologist)</span></div>" +
"<div style='position:absolute;left:204.98px;top:349.43px' class='cls_010'><span class='cls_010'>can be used to treat the first recurrence. Withhold</span></div>" +
"<div style='position:absolute;left:204.98px;top:360.95px' class='cls_010'><span class='cls_010'>antibiotic treatment if symptoms mild.</span></div>" +
"<div style='position:absolute;left:204.98px;top:379.79px' class='cls_040'><span class='cls_040'>PHE - </span><span class='cls_042'>Clostridium difficile</span></div>" +
"<div style='position:absolute;left:204.98px;top:398.99px' class='cls_010'><span class='cls_010'>Check antibiotic history. Each course of clarithromycin,</span></div>" +
"<div style='position:absolute;left:467.33px;top:398.99px' class='cls_010'><span class='cls_010'>PPI (eg Lansoprazole</span></div>" +
"<div style='position:absolute;left:204.98px;top:410.51px' class='cls_010'><span class='cls_010'>metronidazole or quinolone increases risk of</span></div>" +
"<div style='position:absolute;left:467.33px;top:410.51px' class='cls_010'><span class='cls_010'>30mg BD) plus</span></div>" +
"<div style='position:absolute;left:204.98px;top:421.91px' class='cls_010'><span class='cls_010'>antimicrobial resistance. Do not use either</span></div>" +
"<div style='position:absolute;left:467.33px;top:421.91px' class='cls_010'><span class='cls_010'>amoxicillin 1G BD with</span></div>" +
"<div style='position:absolute;left:204.98px;top:433.43px' class='cls_010'><span class='cls_010'>metronidazole or clarithromycin if used in the past year</span></div>" +
"<div style='position:absolute;left:467.33px;top:433.43px' class='cls_010'><span class='cls_010'>either Clarithromycin</span></div>" +
"<div style='position:absolute;left:72.00px;top:439.07px' class='cls_028'><span class='cls_028'>Helicobacter pylori</span></div>" +
"<div style='position:absolute;left:204.98px;top:444.95px' class='cls_010'><span class='cls_010'>for any infection. SEE CURRENT BNF FOR</span></div>" +
"<div style='position:absolute;left:467.33px;top:444.95px' class='cls_010'><span class='cls_010'>500mg BD or</span></div>" +
"<div style='position:absolute;left:708.34px;top:444.95px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:72.00px;top:450.71px' class='cls_010'><span class='cls_010'>eradication (positive test)</span></div>" +
"<div style='position:absolute;left:204.98px;top:456.47px' class='cls_010'><span class='cls_010'>INFORMATION. It is not usually necessary to continue</span></div>" +
"<div style='position:absolute;left:467.33px;top:456.47px' class='cls_010'><span class='cls_010'>Metronidazole 400mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:468.02px' class='cls_010'><span class='cls_010'>PPI therapy but if the ulcer is large, haemorrhaging or</span></div>" +
"<div style='position:absolute;left:467.33px;top:468.02px' class='cls_010'><span class='cls_010'>BD </span><span class='cls_041'>OR </span><span class='cls_010'>PPI (eg</span></div>" +
"<div style='position:absolute;left:204.98px;top:479.54px' class='cls_010'><span class='cls_010'>perforated then PPI treatment can be continued for 3</span></div>" +
"<div style='position:absolute;left:467.33px;top:479.54px' class='cls_010'><span class='cls_010'>Lansoprazole 30mg BD)</span></div>" +
"<div style='position:absolute;left:204.98px;top:490.94px' class='cls_010'><span class='cls_010'>weeks. Discuss treatment with local gastroenterologists</span></div>" +
"<div style='position:absolute;left:467.33px;top:490.94px' class='cls_010'><span class='cls_010'>plus Clarithromycin</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>28</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:17924px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background29.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>to ensure compliance with local guidelines. If diarrhoea</span></div>" +
"<div style='position:absolute;left:467.33px;top:115.26px' class='cls_010'><span class='cls_010'>250mg BD with</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.66px' class='cls_010'><span class='cls_010'>develops, consider </span><span class='cls_028'>Clostridium difficile </span><span class='cls_010'>and review</span></div>" +
"<div style='position:absolute;left:467.33px;top:126.78px' class='cls_010'><span class='cls_010'>Metronidazole 400mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_010'><span class='cls_010'>treatment need.</span></div>" +
"<div style='position:absolute;left:467.33px;top:138.30px' class='cls_010'><span class='cls_010'>BD</span></div>" +
"<div style='position:absolute;left:587.71px;top:150.30px' class='cls_010'><span class='cls_010'>PPI BD plus 2 unused</span></div>" +
"<div style='position:absolute;left:587.71px;top:161.82px' class='cls_010'><span class='cls_010'>antibiotics: amoxicillin</span></div>" +
"<div style='position:absolute;left:587.71px;top:173.22px' class='cls_010'><span class='cls_010'>1G BD, metronidazole</span></div>" +
"<div style='position:absolute;left:587.71px;top:184.74px' class='cls_010'><span class='cls_010'>400mg BD, tetracycline</span></div>" +
"<div style='position:absolute;left:708.34px;top:190.53px' class='cls_010'><span class='cls_010'>14 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:196.29px' class='cls_010'><span class='cls_010'>500mg QDS,</span></div>" +
"<div style='position:absolute;left:204.98px;top:203.49px' class='cls_040'><span class='cls_040'>PHE - </span><span class='cls_042'>Helicobacter pylori</span></div>" +
"<div style='position:absolute;left:587.71px;top:207.81px' class='cls_010'><span class='cls_010'>clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:219.33px' class='cls_010'><span class='cls_010'>BD, levofloxacin</span><span class='cls_011'>♣</span></div>" +
"<div style='position:absolute;left:587.71px;top:230.85px' class='cls_010'><span class='cls_010'>250mg BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:242.85px' class='cls_010'><span class='cls_010'>Treat all household contacts. Advise morning</span></div>" +
"<div style='position:absolute;left:204.98px;top:254.25px' class='cls_010'><span class='cls_010'>showers/baths and general hand hygiene for 2 weeks</span></div>" +
"<div style='position:absolute;left:204.98px;top:265.77px' class='cls_010'><span class='cls_010'>PLUS wash sleepwear, bed linen, dust and vacuum on</span></div>" +
"<div style='position:absolute;left:467.33px;top:273.09px' class='cls_010'><span class='cls_010'>Mebendazole 100mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:277.29px' class='cls_010'><span class='cls_010'>day one. Also clean bathroom thoroughly, by damp</span></div>" +
"<div style='position:absolute;left:467.33px;top:284.49px' class='cls_010'><span class='cls_010'>stat (for adults and</span></div>" +
"<div style='position:absolute;left:708.34px;top:284.49px' class='cls_010'><span class='cls_010'>Stat dose</span></div>" +
"<div style='position:absolute;left:204.98px;top:288.81px' class='cls_010'><span class='cls_010'>dusting surfaces with cloth rinsed frequently in hot water.</span></div>" +
"<div style='position:absolute;left:72.00px;top:296.01px' class='cls_010'><span class='cls_010'>Threadworm</span></div>" +
"<div style='position:absolute;left:467.33px;top:296.01px' class='cls_010'><span class='cls_010'>children over 6 months</span></div>" +
"<div style='position:absolute;left:708.34px;top:296.01px' class='cls_010'><span class='cls_010'>and repeated</span></div>" +
"<div style='position:absolute;left:204.98px;top:300.33px' class='cls_010'><span class='cls_010'>For children under the age of 6 months and pregnant</span></div>" +
"<div style='position:absolute;left:467.33px;top:307.53px' class='cls_010'><span class='cls_010'>but unlicensed in</span></div>" +
"<div style='position:absolute;left:708.34px;top:307.53px' class='cls_010'><span class='cls_010'>after 14 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:311.85px' class='cls_010'><span class='cls_010'>women, physical removal of eggs and hygiene</span></div>" +
"<div style='position:absolute;left:467.33px;top:319.05px' class='cls_010'><span class='cls_010'>children under 2 years)</span></div>" +
"<div style='position:absolute;left:204.98px;top:323.25px' class='cls_010'><span class='cls_010'>measures should be used for 6 weeks.</span></div>" +
"<div style='position:absolute;left:204.98px;top:342.35px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/threadworm'>CKS - Threadworm</A></div>" +
"<div style='position:absolute;left:204.98px;top:361.31px' class='cls_010'><span class='cls_010'>Broad spectrum antibiotics should be prescribed to</span></div>" +
"<div style='position:absolute;left:204.98px;top:372.83px' class='cls_010'><span class='cls_010'>cover both anaerobes and Gram-negative rods.</span></div>" +
"<div style='position:absolute;left:204.98px;top:384.35px' class='cls_010'><span class='cls_010'>Paracetamol should be prescribed for pain (avoid</span></div>" +
"<div style='position:absolute;left:587.71px;top:390.11px' class='cls_010'><span class='cls_010'>Metronidazole 400mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:395.75px' class='cls_010'><span class='cls_010'>NSAIDs and opioid analgesics where possible due to</span></div>" +
"<div style='position:absolute;left:467.33px;top:401.51px' class='cls_010'><span class='cls_010'>Co-amoxiclav</span><span class='cls_011'>♣</span><span class='cls_010'> 625mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:401.51px' class='cls_010'><span class='cls_010'>TDS plus Ciprofloxacin</span><span class='cls_011'>♣</span></div>" +
"<div style='position:absolute;left:72.00px;top:407.27px' class='cls_010'><span class='cls_010'>Diverticulitis (acute)</span></div>" +
"<div style='position:absolute;left:204.98px;top:407.27px' class='cls_010'><span class='cls_010'>increased risk of diverticular perforation) and the patient</span></div>" +
"<div style='position:absolute;left:708.34px;top:407.27px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:413.03px' class='cls_010'><span class='cls_010'>TDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:413.03px' class='cls_010'><span class='cls_010'>500mg BD in penicillin</span></div>" +
"<div style='position:absolute;left:204.98px;top:418.79px' class='cls_010'><span class='cls_010'>should be advised to consume clear liquids only. Solid</span></div>" +
"<div style='position:absolute;left:587.71px;top:424.55px' class='cls_010'><span class='cls_010'>allergy</span></div>" +
"<div style='position:absolute;left:204.98px;top:430.31px' class='cls_010'><span class='cls_010'>food can be gradually introduced as symptoms improve</span></div>" +
"<div style='position:absolute;left:204.98px;top:441.83px' class='cls_010'><span class='cls_010'>over 2 to 3 days. Review within 48 hours or sooner if</span></div>" +
"<div style='position:absolute;left:204.98px;top:453.35px' class='cls_010'><span class='cls_010'>symptoms deteriorate.</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>29</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:18529px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background30.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:133.50px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/diverticular-disease#!scenario:2'>CKS - Acute Diverticulitis</A></div>" +
"<div style='position:absolute;left:72.00px;top:170.58px' class='cls_023'><span class='cls_023'>GENITAL TRACT INFECTIONS - BASHH GUIDELINES.</span><span class='cls_010'> Refer all patients and contacts with suspected STIs to GUM clinic.</span></div>" +
"<div style='position:absolute;left:72.00px;top:196.77px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.bashh.org/guidelines'>Guidelines - BASHH</A></div>" +
"<div style='position:absolute;left:204.98px;top:215.73px' class='cls_010'><span class='cls_010'>Evidence shows that oral triazoles are as effective as</span></div>" +
"<div style='position:absolute;left:204.98px;top:227.25px' class='cls_010'><span class='cls_010'>vaginal imidazoles. Avoid oral triazoles in pregnancy.</span></div>" +
"<div style='position:absolute;left:204.98px;top:238.65px' class='cls_010'><span class='cls_010'>There are many other options for treatment including a 3</span></div>" +
"<div style='position:absolute;left:204.98px;top:250.17px' class='cls_010'><span class='cls_010'>day course of clotrimazole 200mg pessary and a 6 day</span></div>" +
"<div style='position:absolute;left:467.33px;top:255.81px' class='cls_010'><span class='cls_010'>Clotrimazole cream 10%</span></div>" +
"<div style='position:absolute;left:204.98px;top:261.69px' class='cls_010'><span class='cls_010'>course of clotrimazole 100mg pessary. Many treatments</span></div>" +
"<div style='position:absolute;left:72.00px;top:267.33px' class='cls_010'><span class='cls_010'>Vaginal candidiasis</span></div>" +
"<div style='position:absolute;left:467.33px;top:267.33px' class='cls_010'><span class='cls_010'>PV or clotrimazole</span></div>" +
"<div style='position:absolute;left:587.71px;top:267.33px' class='cls_010'><span class='cls_010'>Fluconazole 150mg oral</span></div>" +
"<div style='position:absolute;left:708.34px;top:267.33px' class='cls_010'><span class='cls_010'>STAT dose</span></div>" +
"<div style='position:absolute;left:204.98px;top:273.21px' class='cls_010'><span class='cls_010'>are available to buy ‘over the counter’.</span></div>" +
"<div style='position:absolute;left:467.33px;top:278.85px' class='cls_010'><span class='cls_010'>500mg pessary</span></div>" +
"<div style='position:absolute;left:204.98px;top:290.61px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/candida-female-genital'>CKS - Candidiasis</A></div>" +
"<div style='position:absolute;left:204.98px;top:313.53px' class='cls_040'><span class='cls_040'> </span><A HREF='https://www.gov.uk/government/uploads/system/uploads/attachment_data/file/345793/Vaginal_Discharge_treatment_guidance.pdf'>PHE - Vaginal candidiasis</A></div>" +
"<div style='position:absolute;left:204.98px;top:330.95px' class='cls_010'><span class='cls_010'>Counsel patient that applicators may be used but care</span></div>" +
"<div style='position:absolute;left:204.98px;top:342.47px' class='cls_010'><span class='cls_010'>must be taken to avoid damage to the cervix. Pessaries</span></div>" +
"<div style='position:absolute;left:204.98px;top:353.87px' class='cls_010'><span class='cls_010'>may be inserted by hand. For vulval symptoms, consider</span></div>" +
"<div style='position:absolute;left:587.71px;top:355.43px' class='cls_010'><span class='cls_010'>Miconazole 2%</span></div>" +
"<div style='position:absolute;left:72.00px;top:361.19px' class='cls_010'><span class='cls_010'>Vaginal candidiasis in</span></div>" +
"<div style='position:absolute;left:467.33px;top:361.19px' class='cls_010'><span class='cls_010'>Clotrimazole 100mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:365.39px' class='cls_010'><span class='cls_010'>prescribing topical clotrimazole cream in addition to</span></div>" +
"<div style='position:absolute;left:587.71px;top:366.95px' class='cls_010'><span class='cls_010'>intravaginal cream one</span></div>" +
"<div style='position:absolute;left:711.10px;top:366.95px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:72.00px;top:372.71px' class='cls_010'><span class='cls_010'>pregnancy</span></div>" +
"<div style='position:absolute;left:467.33px;top:372.71px' class='cls_010'><span class='cls_010'>pessary</span></div>" +
"<div style='position:absolute;left:204.98px;top:376.91px' class='cls_010'><span class='cls_010'>intravaginal clotrimazole or miconazole.</span></div>" +
"<div style='position:absolute;left:587.71px;top:378.47px' class='cls_010'><span class='cls_010'>applicatorful BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:395.87px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/candida-female-genital#!scenario:3'>CKS - Candida in pregnancy</A></div>" +
"<div style='position:absolute;left:467.33px;top:416.15px' class='cls_010'><span class='cls_010'>Metronidazole 400mg</span></div>" +
"<div style='position:absolute;left:708.34px;top:421.91px' class='cls_010'><span class='cls_010'>5 to 7 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:427.67px' class='cls_010'><span class='cls_010'>BD or 2g stat</span></div>" +
"<div style='position:absolute;left:204.98px;top:430.67px' class='cls_010'><span class='cls_010'>A stat dose of metronidazole 2g is associated with a</span></div>" +
"<div style='position:absolute;left:204.98px;top:442.19px' class='cls_010'><span class='cls_010'>higher relapse rate than a 7 day course. Avoid 2g stat</span></div>" +
"<div style='position:absolute;left:587.71px;top:442.19px' class='cls_010'><span class='cls_010'>Clindamycin 2% vaginal</span></div>" +
"<div style='position:absolute;left:72.00px;top:447.95px' class='cls_010'><span class='cls_010'>Bacterial vaginosis</span></div>" +
"<div style='position:absolute;left:708.34px;top:447.95px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:453.71px' class='cls_010'><span class='cls_010'>dose in pregnancy. Topical treatment gives similar cure</span></div>" +
"<div style='position:absolute;left:587.71px;top:453.71px' class='cls_010'><span class='cls_010'>cream 5g at night</span></div>" +
"<div style='position:absolute;left:204.98px;top:465.14px' class='cls_010'><span class='cls_010'>rates but is more expensive.</span></div>" +
"<div style='position:absolute;left:587.71px;top:468.26px' class='cls_010'><span class='cls_010'>Metronidazole 0.75%</span></div>" +
"<div style='position:absolute;left:708.34px;top:473.90px' class='cls_010'><span class='cls_010'>5 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:479.66px' class='cls_010'><span class='cls_010'>vaginal gel 5g at night</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>30</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:19134px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background31.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:117.06px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/bacterial-vaginosis'>CKS - Bacterial vaginosis</A></div>" +
"<div style='position:absolute;left:204.98px;top:140.10px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.bashh.org/documents/4413.pdf'>BASHH - Bacterial vaginosis</A></div>" +
"<div style='position:absolute;left:204.98px;top:163.02px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.bashh.org/documents/BV%20PIL%20Screen%20-%20Edit.pdf'>BASHH - Bacterial vaginosis (PIL)</A></div>" +
"<div style='position:absolute;left:204.98px;top:176.94px' class='cls_010'><span class='cls_010'>All people with a positive chlamydia test should be</span></div>" +
"<div style='position:absolute;left:467.33px;top:183.90px' class='cls_010'><span class='cls_010'>Azithromycin 1g</span></div>" +
"<div style='position:absolute;left:708.34px;top:183.90px' class='cls_010'><span class='cls_010'>STAT dose</span></div>" +
"<div style='position:absolute;left:204.98px;top:188.34px' class='cls_010'><span class='cls_010'>offered treatment, support to notify partners and testing</span></div>" +
"<div style='position:absolute;left:204.98px;top:199.89px' class='cls_010'><span class='cls_010'>for other STIs. This service can be provided by GPs or</span></div>" +
"<div style='position:absolute;left:204.98px;top:211.41px' class='cls_010'><span class='cls_010'>GUM clinics. Refer to BASHH guidelines in pregnancy or</span></div>" +
"<div style='position:absolute;left:204.98px;top:222.93px' class='cls_010'><span class='cls_010'>breastfeeding as doxycycline is contraindicated and test</span></div>" +
"<div style='position:absolute;left:72.00px;top:235.17px' class='cls_028'><span class='cls_028'>Chlamydia trachomatis</span></div>" +
"<div style='position:absolute;left:204.98px;top:234.45px' class='cls_010'><span class='cls_010'>for cure 6 weeks after treatment (5 weeks with</span></div>" +
"<div style='position:absolute;left:204.98px;top:245.85px' class='cls_010'><span class='cls_010'>erythromycin) due to lower cure rate in pregnancy.</span></div>" +
"<div style='position:absolute;left:587.71px;top:248.37px' class='cls_010'><span class='cls_010'>Doxycycline 100mg BD</span></div>" +
"<div style='position:absolute;left:708.34px;top:248.37px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:264.33px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/chlamydia-uncomplicated-genital'>CKS - Chlamydia</A></div>" +
"<div style='position:absolute;left:204.98px;top:287.37px' class='cls_040'><span class='cls_040'> </span><A HREF='https://www.gov.uk/government/collections/chlamydia-surveillance-data-screening-and-management'>PHE - Chlamydia</A></div>" +
"<div style='position:absolute;left:587.71px;top:305.73px' class='cls_041'><span class='cls_041'>Under 35 years and/or</span></div>" +
"<div style='position:absolute;left:204.98px;top:317.25px' class='cls_010'><span class='cls_010'>Use ofloxacin</span><span class='cls_011'>♣</span><span class='cls_010'> for all cases where patient is allergic to</span></div>" +
"<div style='position:absolute;left:587.71px;top:317.25px' class='cls_041'><span class='cls_041'>high risk of sexually</span></div>" +
"<div style='position:absolute;left:204.98px;top:328.79px' class='cls_010'><span class='cls_010'>cephalosporins</span><span class='cls_011'>♣</span><span class='cls_010'> and/or doxycycline. If quinolones</span><span class='cls_011'>♣</span><span class='cls_010'> are</span></div>" +
"<div style='position:absolute;left:587.71px;top:328.79px' class='cls_041'><span class='cls_041'>transmitted infection</span></div>" +
"<div style='position:absolute;left:708.34px;top:334.55px' class='cls_010'><span class='cls_010'>14 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:340.31px' class='cls_010'><span class='cls_010'>contraindicated, co-amoxiclav</span><span class='cls_011'>♣</span><span class='cls_010'> 625mg TDS for 10 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:340.31px' class='cls_041'><span class='cls_041'>(non - gonoccocal)</span></div>" +
"<div style='position:absolute;left:467.33px;top:346.31px' class='cls_041'><span class='cls_041'>Due to any sexually</span></div>" +
"<div style='position:absolute;left:204.98px;top:351.71px' class='cls_010'><span class='cls_010'>can be used.</span></div>" +
"<div style='position:absolute;left:587.71px;top:351.71px' class='cls_010'><span class='cls_010'>Doxycycline 100mg BD</span></div>" +
"<div style='position:absolute;left:467.33px;top:357.71px' class='cls_041'><span class='cls_041'>transmitted pathogen</span></div>" +
"<div style='position:absolute;left:587.71px;top:363.23px' class='cls_010'><span class='cls_010'>or ofloxacin</span><span class='cls_011'>♣ </span><span class='cls_010'>200mg BD</span></div>" +
"<div style='position:absolute;left:467.33px;top:369.23px' class='cls_010'><span class='cls_010'>Ceftriaxone</span><span class='cls_011'>♣</span><span class='cls_010'> 500mg IM</span></div>" +
"<div style='position:absolute;left:72.00px;top:374.99px' class='cls_010'><span class='cls_010'>Epididymo-orchitis</span></div>" +
"<div style='position:absolute;left:587.71px;top:375.23px' class='cls_041'><span class='cls_041'>Over 35 years and/or</span></div>" +
"<div style='position:absolute;left:467.33px;top:380.75px' class='cls_010'><span class='cls_010'>(stat) PLUS doxycycline</span></div>" +
"<div style='position:absolute;left:204.98px;top:386.75px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/scrotal-swellings'>CKS - Epididymo-orchitis</A></div>" +
"<div style='position:absolute;left:587.71px;top:386.75px' class='cls_041'><span class='cls_041'>low risk of sexually</span></div>" +
"<div style='position:absolute;left:467.33px;top:392.27px' class='cls_010'><span class='cls_010'>100mg BD for 10 to 14</span></div>" +
"<div style='position:absolute;left:587.71px;top:398.27px' class='cls_041'><span class='cls_041'>transmitted infection</span></div>" +
"<div style='position:absolute;left:467.33px;top:403.79px' class='cls_010'><span class='cls_010'>days</span></div>" +
"<div style='position:absolute;left:204.98px;top:409.79px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.bashh.org/documents/3546.pdf'>BASHH - Epididymo-orchitis</A></div>" +
"<div style='position:absolute;left:587.71px;top:409.79px' class='cls_010'><span class='cls_010'>Ciprofloxacin</span><span class='cls_011'>♣</span><span class='cls_010'> 500mg</span></div>" +
"<div style='position:absolute;left:708.34px;top:409.79px' class='cls_010'><span class='cls_010'>10 to 14 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:421.31px' class='cls_010'><span class='cls_010'>BD (10 days) or</span></div>" +
"<div style='position:absolute;left:204.98px;top:432.71px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.bashh.org/BASHH/Public___patient_information/Information_on_STIs/Epidiymo-orchitis.aspx'>BASHH - Epididymo-orchitis (PIL)</A></div>" +
"<div style='position:absolute;left:587.71px;top:432.71px' class='cls_010'><span class='cls_010'>Ofloxacin</span><span class='cls_011'>♣</span><span class='cls_010'> 200mg BD</span></div>" +
"<div style='position:absolute;left:587.71px;top:444.23px' class='cls_010'><span class='cls_010'>(14 days)</span></div>" +
"<div style='position:absolute;left:204.98px;top:457.55px' class='cls_010'><span class='cls_010'>Refer to GUM clinic and treat partners simultaneously.</span></div>" +
"<div style='position:absolute;left:467.33px;top:457.55px' class='cls_010'><span class='cls_010'>Metronidazole 400mg to</span></div>" +
"<div style='position:absolute;left:72.00px;top:463.22px' class='cls_028'><span class='cls_028'>Trichomonas vaginalis</span></div>" +
"<div style='position:absolute;left:587.71px;top:463.34px' class='cls_010'><span class='cls_010'>Tinidazole 2g stat</span></div>" +
"<div style='position:absolute;left:708.34px;top:463.34px' class='cls_010'><span class='cls_010'>5 - 7 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:469.10px' class='cls_010'><span class='cls_010'>Avoid 2g stat dose in pregnancy.</span></div>" +
"<div style='position:absolute;left:467.33px;top:469.10px' class='cls_010'><span class='cls_010'>500mg BD or 2g stat</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>31</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:19739px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background32.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.f18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/trichomoniasis'>CKS - Trichomoniasis</A></div>" +
"<div style='position:absolute;left:204.98px;top:149.82px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.bashh.org/documents/UK%20national%20guideline%20on%20the%20management%20of%20TV%20%202014.pdf'>BASHH - Trichomonas vaginalis</A></div>" +
"<div style='position:absolute;left:204.98px;top:172.74px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.bashh.org/documents/TV%20PIL%20Screen%20-%20Edit.pdf'>BASHH - Trichomonas vaginalis (PIL)</A></div>" +
"<div style='position:absolute;left:204.98px;top:207.69px' class='cls_010'><span class='cls_010'>Refer patients and contacts to GUM clinic. Test for </span><span class='cls_028'>N.</span></div>" +
"<div style='position:absolute;left:204.98px;top:219.21px' class='cls_028'><span class='cls_028'>Gonorrhoeae</span><span class='cls_010'> and Chlamydia. There is emerging clinical</span></div>" +
"<div style='position:absolute;left:467.33px;top:220.53px' class='cls_010'><span class='cls_010'>Ceftriaxone</span><span class='cls_011'>♣</span><span class='cls_010'> 500mg IM</span></div>" +
"<div style='position:absolute;left:204.98px;top:230.85px' class='cls_010'><span class='cls_010'>resistance to quinolones</span><span class='cls_011'>♣</span><span class='cls_010'> and they therefore should not</span></div>" +
"<div style='position:absolute;left:467.33px;top:232.05px' class='cls_010'><span class='cls_010'>(single dose) plus</span></div>" +
"<div style='position:absolute;left:587.71px;top:232.05px' class='cls_010'><span class='cls_010'>Metronidazole 400mg</span></div>" +
"<div style='position:absolute;left:72.00px;top:243.57px' class='cls_010'><span class='cls_010'>Pelvic Inflammatory</span></div>" +
"<div style='position:absolute;left:204.98px;top:242.25px' class='cls_010'><span class='cls_010'>be used for patients at high risk of gonococcal infection.</span></div>" +
"<div style='position:absolute;left:467.33px;top:243.57px' class='cls_010'><span class='cls_010'>metronidazole 400mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:243.57px' class='cls_010'><span class='cls_010'>BD plus ofloxacin</span><span class='cls_011'>♣</span></div>" +
"<div style='position:absolute;left:708.34px;top:249.33px' class='cls_010'><span class='cls_010'>14 days</span></div>" +
"<div style='position:absolute;left:72.00px;top:255.09px' class='cls_010'><span class='cls_010'>Disease (PID)</span></div>" +
"<div style='position:absolute;left:467.33px;top:255.09px' class='cls_010'><span class='cls_010'>BD plus doxycycline</span></div>" +
"<div style='position:absolute;left:587.71px;top:255.09px' class='cls_010'><span class='cls_010'>400mg BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:261.09px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.bashh.org/documents/4238.pdf'>BASHH - PID (PIL)</A></div>" +
"<div style='position:absolute;left:467.33px;top:266.49px' class='cls_010'><span class='cls_010'>100mg BD if gonorrhoea</span></div>" +
"<div style='position:absolute;left:467.33px;top:278.01px' class='cls_010'><span class='cls_010'>likely</span></div>" +
"<div style='position:absolute;left:204.98px;top:284.01px' class='cls_040'><span class='cls_040'> </span><A HREF='http://www.bashh.org/documents/3572.pdf'>BASHH - PID</A></div>" +
"<div style='position:absolute;left:72.00px;top:309.69px' class='cls_023'><span class='cls_023'>SKIN INFECTIONS</span></div>" +
"<div style='position:absolute;left:204.98px;top:328.79px' class='cls_010'><span class='cls_010'>For mild acne, a topical retinoid such as adapalene</span></div>" +
"<div style='position:absolute;left:204.98px;top:340.31px' class='cls_010'><span class='cls_010'>should be used first line. Oral antibiotics and topical</span></div>" +
"<div style='position:absolute;left:204.98px;top:351.83px' class='cls_010'><span class='cls_010'>antibiotics should not be prescribed together. For</span></div>" +
"<div style='position:absolute;left:711.10px;top:353.27px' class='cls_010'><span class='cls_010'>Up to 6</span></div>" +
"<div style='position:absolute;left:587.71px;top:359.03px' class='cls_010'><span class='cls_010'>Erythromycin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:363.35px' class='cls_010'><span class='cls_010'>moderate or severe acne, prescribe an oral antibiotic in</span></div>" +
"<div style='position:absolute;left:708.34px;top:364.79px' class='cls_010'><span class='cls_010'>months</span></div>" +
"<div style='position:absolute;left:467.33px;top:370.55px' class='cls_010'><span class='cls_010'>Lymecycline 408mg OD</span></div>" +
"<div style='position:absolute;left:587.71px;top:370.55px' class='cls_010'><span class='cls_010'>(2x250mg) BD (in</span></div>" +
"<div style='position:absolute;left:204.98px;top:374.87px' class='cls_010'><span class='cls_010'>combination with a topical retinoid or benzoyl peroxide.</span></div>" +
"<div style='position:absolute;left:708.34px;top:376.31px' class='cls_010'><span class='cls_010'>Discontinue</span></div>" +
"<div style='position:absolute;left:72.00px;top:382.07px' class='cls_010'><span class='cls_010'>Acne (moderate or severe)</span></div>" +
"<div style='position:absolute;left:467.33px;top:382.07px' class='cls_010'><span class='cls_010'>or Oxytetracycline</span></div>" +
"<div style='position:absolute;left:587.71px;top:382.07px' class='cls_010'><span class='cls_010'>pregnancy or if</span></div>" +
"<div style='position:absolute;left:204.98px;top:386.27px' class='cls_010'><span class='cls_010'>Tetracyclines should not be used in pregnancy,</span></div>" +
"<div style='position:absolute;left:708.34px;top:387.83px' class='cls_010'><span class='cls_010'>when further</span></div>" +
"<div style='position:absolute;left:467.33px;top:393.59px' class='cls_010'><span class='cls_010'>500mg BD</span></div>" +
"<div style='position:absolute;left:587.71px;top:393.59px' class='cls_010'><span class='cls_010'>tetracyclines not</span></div>" +
"<div style='position:absolute;left:204.98px;top:397.79px' class='cls_010'><span class='cls_010'>breastfeeding or in children under the age of 12 as they</span></div>" +
"<div style='position:absolute;left:708.34px;top:399.35px' class='cls_010'><span class='cls_010'>improvement</span></div>" +
"<div style='position:absolute;left:587.71px;top:405.11px' class='cls_010'><span class='cls_010'>tolerated)</span></div>" +
"<div style='position:absolute;left:204.98px;top:409.31px' class='cls_010'><span class='cls_010'>are deposited in teeth and bones.</span></div>" +
"<div style='position:absolute;left:708.34px;top:410.87px' class='cls_010'><span class='cls_010'>is unlikely.</span></div>" +
"<div style='position:absolute;left:204.98px;top:428.27px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/acne-vulgaris'>CKS - Acne</A></div>" +
"<div style='position:absolute;left:204.98px;top:447.35px' class='cls_010'><span class='cls_010'>Thorough irrigation is important. Antibiotic prophylaxis</span></div>" +
"<div style='position:absolute;left:587.71px;top:447.35px' class='cls_010'><span class='cls_010'>Animal Bites (penicillin</span></div>" +
"<div style='position:absolute;left:467.33px;top:453.11px' class='cls_010'><span class='cls_010'>Co-amoxiclav</span><span class='cls_011'>♣</span><span class='cls_010'> 375mg -</span></div>" +
"<div style='position:absolute;left:204.98px;top:458.78px' class='cls_010'><span class='cls_010'>(antibiotics and duration as for treatment - CKS) advised</span></div>" +
"<div style='position:absolute;left:587.71px;top:458.78px' class='cls_010'><span class='cls_010'>allergy) Metronidazole</span></div>" +
"<div style='position:absolute;left:72.00px;top:464.54px' class='cls_010'><span class='cls_010'>Bites (animal and human)</span></div>" +
"<div style='position:absolute;left:467.33px;top:464.54px' class='cls_010'><span class='cls_010'>625mg TDS (animal and</span></div>" +
"<div style='position:absolute;left:708.34px;top:464.54px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:470.30px' class='cls_010'><span class='cls_010'>for all cat bites; animal bites to the hand, foot or face;</span></div>" +
"<div style='position:absolute;left:587.71px;top:470.30px' class='cls_010'><span class='cls_010'>400mg TDS plus</span></div>" +
"<div style='position:absolute;left:467.33px;top:476.06px' class='cls_010'><span class='cls_010'>human)</span></div>" +
"<div style='position:absolute;left:204.98px;top:481.82px' class='cls_010'><span class='cls_010'>puncture wounds; wounds requiring surgical</span></div>" +
"<div style='position:absolute;left:587.71px;top:481.82px' class='cls_010'><span class='cls_010'>doxycycline 100mg BD</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>32</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:20344px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background33.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>debridement; wounds involving joints, tendons,</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_010'><span class='cls_010'>ligaments or suspected fractures. Also patients at risk of</span></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_010'><span class='cls_010'>serious wound infection e.g. diabetics, cirrhotics,</span></div>" +
"<div style='position:absolute;left:587.71px;top:145.50px' class='cls_010'><span class='cls_010'>Human Bites (penicillin</span></div>" +
"<div style='position:absolute;left:204.98px;top:149.82px' class='cls_010'><span class='cls_010'>asplenic or immunocompromised patients and the</span></div>" +
"<div style='position:absolute;left:587.71px;top:157.02px' class='cls_010'><span class='cls_010'>allergy) Metronidazole</span></div>" +
"<div style='position:absolute;left:204.98px;top:161.22px' class='cls_010'><span class='cls_010'>elderly. Antibiotic prophylaxis advised for all human bites</span></div>" +
"<div style='position:absolute;left:587.71px;top:168.54px' class='cls_010'><span class='cls_010'>200mg to 400mg TDS</span></div>" +
"<div style='position:absolute;left:708.34px;top:168.54px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:172.74px' class='cls_010'><span class='cls_010'>and review after 24 and 48 hours if infected. Assess for</span></div>" +
"<div style='position:absolute;left:587.71px;top:180.06px' class='cls_010'><span class='cls_010'>plus clarithromycin</span></div>" +
"<div style='position:absolute;left:204.98px;top:184.26px' class='cls_010'><span class='cls_010'>HIV, tetanus, hepatitis B&C in human bites and tetanus</span></div>" +
"<div style='position:absolute;left:587.71px;top:191.61px' class='cls_010'><span class='cls_010'>250mg to 500mg BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:195.81px' class='cls_010'><span class='cls_010'>and rabies risk in animal bites.</span></div>" +
"<div style='position:absolute;left:204.98px;top:214.77px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/bites-human-and-animal'>CKS - Bites</A></div>" +
"<div style='position:absolute;left:204.98px;top:233.85px' class='cls_010'><span class='cls_010'>Treat as for cellulitis if infected. Fever/lymphangitis are</span></div>" +
"<div style='position:absolute;left:204.98px;top:245.25px' class='cls_010'><span class='cls_010'>indicators for treatment. Hot/sore bites may be due to</span></div>" +
"<div style='position:absolute;left:587.71px;top:252.57px' class='cls_010'><span class='cls_010'>Clarithromycin 250mg -</span></div>" +
"<div style='position:absolute;left:204.98px;top:256.77px' class='cls_010'><span class='cls_010'>local histamine release.</span></div>" +
"<div style='position:absolute;left:467.33px;top:258.33px' class='cls_010'><span class='cls_010'>Flucloxacillin 250mg -</span></div>" +
"<div style='position:absolute;left:72.00px;top:264.09px' class='cls_010'><span class='cls_010'>Bites (insect)</span></div>" +
"<div style='position:absolute;left:587.71px;top:264.09px' class='cls_010'><span class='cls_010'>500mg BD (penicillin</span></div>" +
"<div style='position:absolute;left:708.34px;top:264.09px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:269.85px' class='cls_010'><span class='cls_010'>500mg QDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:275.49px' class='cls_010'><span class='cls_010'>allergy)</span></div>" +
"<div style='position:absolute;left:204.98px;top:287.25px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/insect-bites-and-stings'>CKS - Insect bites</A></div>" +
"<div style='position:absolute;left:204.98px;top:306.33px' class='cls_010'><span class='cls_010'>Antibiotics are not always necessary but can be</span></div>" +
"<div style='position:absolute;left:587.71px;top:313.53px' class='cls_010'><span class='cls_010'>Clarithromycin 250mg -</span></div>" +
"<div style='position:absolute;left:204.98px;top:317.85px' class='cls_010'><span class='cls_010'>considered if the lesion is large or there is associated</span></div>" +
"<div style='position:absolute;left:587.71px;top:325.07px' class='cls_010'><span class='cls_010'>500mg BD (penicillin</span></div>" +
"<div style='position:absolute;left:204.98px;top:329.27px' class='cls_010'><span class='cls_010'>fever or cellulitis, there are co-morbidities e.g. diabetes</span></div>" +
"<div style='position:absolute;left:467.33px;top:336.59px' class='cls_010'><span class='cls_010'>Flucloxacillin 250mg -</span></div>" +
"<div style='position:absolute;left:587.71px;top:336.59px' class='cls_010'><span class='cls_010'>allergy) or erythromycin</span></div>" +
"<div style='position:absolute;left:72.00px;top:342.35px' class='cls_010'><span class='cls_010'>Boils</span></div>" +
"<div style='position:absolute;left:204.98px;top:340.79px' class='cls_010'><span class='cls_010'>or complications are more likely because of the site</span></div>" +
"<div style='position:absolute;left:708.34px;top:342.35px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:348.11px' class='cls_010'><span class='cls_010'>500mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:348.11px' class='cls_010'><span class='cls_010'>250mg - 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:352.31px' class='cls_010'><span class='cls_010'>affected e.g. face. Self care advice should also be given</span></div>" +
"<div style='position:absolute;left:587.71px;top:359.51px' class='cls_010'><span class='cls_010'>(2x250mg) QDS (in</span></div>" +
"<div style='position:absolute;left:204.98px;top:371.27px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/boils-carbuncles-and-staphylococcal-carriage'>CKS - Boils</A></div>" +
"<div style='position:absolute;left:587.71px;top:371.03px' class='cls_010'><span class='cls_010'>pregnancy)</span></div>" +
"<div style='position:absolute;left:204.98px;top:390.35px' class='cls_010'><span class='cls_010'>Patients who are afebrile and otherwise healthy should</span></div>" +
"<div style='position:absolute;left:587.71px;top:391.55px' class='cls_010'><span class='cls_010'>Clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:401.87px' class='cls_010'><span class='cls_010'>be treated as indicated with a single antibiotic. If</span></div>" +
"<div style='position:absolute;left:587.71px;top:403.07px' class='cls_010'><span class='cls_010'>BD (penicillin allergy)</span></div>" +
"<div style='position:absolute;left:204.98px;top:413.27px' class='cls_010'><span class='cls_010'>response is slow, treat for a further 7 days. Consider</span></div>" +
"<div style='position:absolute;left:467.33px;top:420.59px' class='cls_010'><span class='cls_010'>Flucloxacillin 500mg</span></div>" +
"<div style='position:absolute;left:708.34px;top:420.59px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:72.00px;top:426.35px' class='cls_010'><span class='cls_010'>Cellulitis - mild or moderate</span></div>" +
"<div style='position:absolute;left:204.98px;top:424.79px' class='cls_010'><span class='cls_010'>referring patients who have recurrent cellulitis, the</span></div>" +
"<div style='position:absolute;left:587.71px;top:427.79px' class='cls_010'><span class='cls_010'>Co-amoxiclav</span><span class='cls_011'>♣</span><span class='cls_010'> (for</span></div>" +
"<div style='position:absolute;left:467.33px;top:432.11px' class='cls_010'><span class='cls_010'>QDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:436.31px' class='cls_010'><span class='cls_010'>elderly and those who are vulnerable to infection.</span></div>" +
"<div style='position:absolute;left:587.71px;top:439.31px' class='cls_010'><span class='cls_010'>facial cellulitis) 625mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:450.83px' class='cls_010'><span class='cls_010'>TDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:455.27px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/cellulitis-acute'>CKS - Cellulitis</A></div>" +
"<div style='position:absolute;left:204.98px;top:475.58px' class='cls_010'><span class='cls_010'>Most infections are viral, self-limiting and will clear within</span></div>" +
"<div style='position:absolute;left:467.33px;top:475.58px' class='cls_010'><span class='cls_010'>Local cleansing of</span></div>" +
"<div style='position:absolute;left:587.71px;top:475.58px' class='cls_010'><span class='cls_010'>Chloramphenicol 0.5%</span></div>" +
"<div style='position:absolute;left:708.34px;top:475.58px' class='cls_010'><span class='cls_010'>For 48 hours</span></div>" +
"<div style='position:absolute;left:72.00px;top:481.34px' class='cls_010'><span class='cls_010'>Conjunctivitis</span></div>" +
"<div style='position:absolute;left:204.98px;top:487.10px' class='cls_010'><span class='cls_010'>1-2 weeks without treatment (even if they are bacterial).</span></div>" +
"<div style='position:absolute;left:467.33px;top:487.10px' class='cls_010'><span class='cls_010'>affected eye(s) using</span></div>" +
"<div style='position:absolute;left:587.71px;top:487.10px' class='cls_010'><span class='cls_010'>drops 2 hourly for 2</span></div>" +
"<div style='position:absolute;left:708.34px;top:487.10px' class='cls_010'><span class='cls_010'>after</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>33</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:20949px;width:841px;height:595px;border-style:outset;overflow:hidden'>" + 
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background34.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>Chloramphenicol is available to buy over the counter for</span></div>" +
"<div style='position:absolute;left:467.33px;top:115.26px' class='cls_010'><span class='cls_010'>boiled, cooled water can</span></div>" +
"<div style='position:absolute;left:587.71px;top:115.26px' class='cls_010'><span class='cls_010'>days then 4 hourly whilst</span></div>" +
"<div style='position:absolute;left:708.34px;top:115.26px' class='cls_010'><span class='cls_010'>resolution</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_010'><span class='cls_010'>patients over the age of 2 years.</span></div>" +
"<div style='position:absolute;left:467.33px;top:126.78px' class='cls_010'><span class='cls_010'>be recommended before</span></div>" +
"<div style='position:absolute;left:587.71px;top:126.78px' class='cls_010'><span class='cls_010'>awake or</span></div>" +
"<div style='position:absolute;left:467.33px;top:138.30px' class='cls_010'><span class='cls_010'>use of topical antibiotics.</span></div>" +
"<div style='position:absolute;left:587.71px;top:138.30px' class='cls_010'><span class='cls_010'>chloramphenicol 1% eye</span></div>" +
"<div style='position:absolute;left:587.71px;top:149.82px' class='cls_010'><span class='cls_010'>ointment at night or</span></div>" +
"<div style='position:absolute;left:204.98px;top:157.02px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/conjunctivitis-infective'>CKS - Conjunctivitis</A></div>" +
"<div style='position:absolute;left:587.71px;top:161.22px' class='cls_010'><span class='cls_010'>fusidic acid eye drops</span></div>" +
"<div style='position:absolute;left:587.71px;top:172.74px' class='cls_010'><span class='cls_010'>1% BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:184.74px' class='cls_010'><span class='cls_010'>Take behind the nail scrapings. Treatment should only</span></div>" +
"<div style='position:absolute;left:204.98px;top:196.29px' class='cls_010'><span class='cls_010'>be started if infection is confirmed. If symptoms are not</span></div>" +
"<div style='position:absolute;left:708.34px;top:202.05px' class='cls_010'><span class='cls_010'>Fingers - 6 to</span></div>" +
"<div style='position:absolute;left:204.98px;top:207.81px' class='cls_010'><span class='cls_010'>troublesome or patients are not at increased risk of</span></div>" +
"<div style='position:absolute;left:708.34px;top:213.57px' class='cls_010'><span class='cls_010'>12 weeks</span></div>" +
"<div style='position:absolute;left:204.98px;top:219.33px' class='cls_010'><span class='cls_010'>developing side effects, then self care measures should</span></div>" +
"<div style='position:absolute;left:467.33px;top:219.33px' class='cls_010'><span class='cls_010'>Terbinafine 250mg OD</span></div>" +
"<div style='position:absolute;left:708.34px;top:225.09px' class='cls_010'><span class='cls_010'>and toes - 3</span></div>" +
"<div style='position:absolute;left:204.98px;top:230.85px' class='cls_010'><span class='cls_010'>be considered. ENHCCG have stated that the treatment</span></div>" +
"<div style='position:absolute;left:708.34px;top:236.49px' class='cls_010'><span class='cls_010'>to 6 months</span></div>" +
"<div style='position:absolute;left:204.98px;top:242.25px' class='cls_010'><span class='cls_010'>of dermatophyte infections is a LOW priority.</span></div>" +
"<div style='position:absolute;left:204.98px;top:253.77px' class='cls_025'><span class='cls_025'> </span><A HREF='http://www.enhertsccg.nhs.uk/sites/default/files/Pharmacy/Local_Decisions/Why%20Are%20Fungal%20Nail%20Infections%20Not%20Routinely%20Treated%20By%20The%20NHS%20In%20Hertfordshire%20-%20July%202012.pdf'>ENHCCG leaflet</A></div>" +
"<div style='position:absolute;left:72.00px;top:265.77px' class='cls_010'><span class='cls_010'>Dermatophyte infection of</span></div>" +
"<div style='position:absolute;left:587.71px;top:265.77px' class='cls_010'><span class='cls_010'>Amorolfine 5% topical</span></div>" +
"<div style='position:absolute;left:708.34px;top:265.77px' class='cls_010'><span class='cls_010'>Fingers - 6</span></div>" +
"<div style='position:absolute;left:72.00px;top:277.29px' class='cls_010'><span class='cls_010'>the finger or toe nail</span></div>" +
"<div style='position:absolute;left:587.71px;top:277.29px' class='cls_010'><span class='cls_010'>paint (very superficial</span></div>" +
"<div style='position:absolute;left:708.34px;top:277.29px' class='cls_010'><span class='cls_010'>months and</span></div>" +
"<div style='position:absolute;left:587.71px;top:288.81px' class='cls_010'><span class='cls_010'>infections only) once or</span></div>" +
"<div style='position:absolute;left:708.34px;top:288.81px' class='cls_010'><span class='cls_010'>toes - 9 to</span></div>" +
"<div style='position:absolute;left:587.71px;top:300.33px' class='cls_010'><span class='cls_010'>twice a week</span></div>" +
"<div style='position:absolute;left:708.34px;top:300.33px' class='cls_010'><span class='cls_010'>12 months</span></div>" +
"<div style='position:absolute;left:204.98px;top:313.53px' class='cls_010'><span class='cls_010'>Fingers require 2 pulsed courses and toes require at</span></div>" +
"<div style='position:absolute;left:708.34px;top:312.33px' class='cls_010'><span class='cls_010'>1 week with</span></div>" +
"<div style='position:absolute;left:204.98px;top:325.07px' class='cls_010'><span class='cls_010'>least 3 courses</span></div>" +
"<div style='position:absolute;left:708.34px;top:323.85px' class='cls_010'><span class='cls_010'>subsequent</span></div>" +
"<div style='position:absolute;left:587.71px;top:329.51px' class='cls_010'><span class='cls_010'>Itraconazole pulsed</span></div>" +
"<div style='position:absolute;left:708.34px;top:335.27px' class='cls_010'><span class='cls_010'>courses</span></div>" +
"<div style='position:absolute;left:587.71px;top:341.03px' class='cls_010'><span class='cls_010'>therapy 200mg BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:348.35px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/fungal-nail-infection'>CKS - Fungal nail infection</A></div>" +
"<div style='position:absolute;left:708.34px;top:346.79px' class='cls_010'><span class='cls_010'>repeated</span></div>" +
"<div style='position:absolute;left:708.34px;top:358.31px' class='cls_010'><span class='cls_010'>after 21 days</span></div>" +
"<div style='position:absolute;left:708.34px;top:370.31px' class='cls_010'><span class='cls_010'>For 1-2</span></div>" +
"<div style='position:absolute;left:708.34px;top:381.83px' class='cls_010'><span class='cls_010'>weeks after</span></div>" +
"<div style='position:absolute;left:467.33px;top:387.59px' class='cls_010'><span class='cls_010'>Clotrimazole 1% cream</span></div>" +
"<div style='position:absolute;left:204.98px;top:394.67px' class='cls_010'><span class='cls_010'>Send skin scrapings and consider </span><span class='cls_028'>oral</span><span class='cls_010'> terbinafine or</span></div>" +
"<div style='position:absolute;left:708.34px;top:393.35px' class='cls_010'><span class='cls_010'>the infected</span></div>" +
"<div style='position:absolute;left:467.33px;top:399.11px' class='cls_010'><span class='cls_010'>BD-TDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:406.31px' class='cls_010'><span class='cls_010'>itraconazole if intractable. Topical terbinafine is as</span></div>" +
"<div style='position:absolute;left:708.34px;top:404.75px' class='cls_010'><span class='cls_010'>area has</span></div>" +
"<div style='position:absolute;left:72.00px;top:413.51px' class='cls_010'><span class='cls_010'>Dermatophyte infection of</span></div>" +
"<div style='position:absolute;left:204.98px;top:417.83px' class='cls_010'><span class='cls_010'>effective as clotrimazole.</span></div>" +
"<div style='position:absolute;left:708.34px;top:416.27px' class='cls_010'><span class='cls_010'>healed</span></div>" +
"<div style='position:absolute;left:72.00px;top:425.03px' class='cls_010'><span class='cls_010'>the skin</span></div>" +
"<div style='position:absolute;left:467.33px;top:436.79px' class='cls_010'><span class='cls_010'>Terbinafine 1% cream</span></div>" +
"<div style='position:absolute;left:467.33px;top:448.31px' class='cls_010'><span class='cls_010'>BD (not licenced for use</span></div>" +
"<div style='position:absolute;left:708.34px;top:448.31px' class='cls_010'><span class='cls_010'>7-14 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:461.30px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/fungal-skin-infection-body-and-groin'>CKS - Fungal skin infection</A></div>" +
"<div style='position:absolute;left:467.33px;top:459.86px' class='cls_010'><span class='cls_010'>in children)</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>34</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:21554px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background35.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>If there are no visible signs of infection, the use of antibiotics either alone or in combination with corticosteroids, encourages</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_010'><span class='cls_010'>resistance and does not improve healing. Consider infection if there is no response to emollients or topical steroids. In infected</span></div>" +
"<div style='position:absolute;left:72.00px;top:132.54px' class='cls_010'><span class='cls_010'>Eczema</span></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_010'><span class='cls_010'>eczema, treat as per impetigo below. </span><A HREF='http://cks.nice.org.uk/eczema-atopic'>CKS - Eczema</A> </span></div>" +
"<div style='position:absolute;left:467.33px;top:161.82px' class='cls_010'><span class='cls_010'>Fusidic acid 2%</span></div>" +
"<div style='position:absolute;left:467.33px;top:173.22px' class='cls_010'><span class='cls_010'>cream/ointment TDS</span></div>" +
"<div style='position:absolute;left:708.34px;top:173.22px' class='cls_010'><span class='cls_010'>5 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:184.74px' class='cls_010'><span class='cls_010'>(non bullous)</span></div>" +
"<div style='position:absolute;left:204.98px;top:192.33px' class='cls_010'><span class='cls_010'>Topical treatments should be reserved for</span></div>" +
"<div style='position:absolute;left:467.33px;top:196.77px' class='cls_010'><span class='cls_010'>Flucloxacillin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:203.85px' class='cls_010'><span class='cls_010'>localised/minor infection to prevent resistance</span></div>" +
"<div style='position:absolute;left:467.33px;top:208.29px' class='cls_010'><span class='cls_010'>QDS (bullous and non</span></div>" +
"<div style='position:absolute;left:708.34px;top:208.29px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:215.25px' class='cls_010'><span class='cls_010'>developing.</span></div>" +
"<div style='position:absolute;left:72.00px;top:219.21px' class='cls_010'><span class='cls_010'>Impetigo</span></div>" +
"<div style='position:absolute;left:467.33px;top:219.81px' class='cls_010'><span class='cls_010'>bullous)</span></div>" +
"<div style='position:absolute;left:587.71px;top:236.97px' class='cls_010'><span class='cls_010'>Clarithromycin 250-</span></div>" +
"<div style='position:absolute;left:587.71px;top:248.49px' class='cls_010'><span class='cls_010'>500mg BD (penicillin</span></div>" +
"<div style='position:absolute;left:708.34px;top:254.25px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:587.71px;top:260.01px' class='cls_010'><span class='cls_010'>allergy - bullous and</span></div>" +
"<div style='position:absolute;left:204.98px;top:267.21px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/impetigo'>CKS - Impetigo</A></div>" +
"<div style='position:absolute;left:587.71px;top:271.41px' class='cls_010'><span class='cls_010'>non bullous)</span></div>" +
"<div style='position:absolute;left:204.98px;top:288.45px' class='cls_009'><span class='cls_009'>Ulcers always colonise at some point. Antibiotics do</span></div>" +
"<div style='position:absolute;left:204.98px;top:299.97px' class='cls_009'><span class='cls_009'>not improve healing unless there is active infection.</span></div>" +
"<div style='position:absolute;left:204.98px;top:311.61px' class='cls_010'><span class='cls_010'>If response is slow, treat for a further 7 days. Swabs and</span></div>" +
"<div style='position:absolute;left:204.98px;top:323.13px' class='cls_010'><span class='cls_010'>antibiotics are only indicated if there is either cellulitis or</span></div>" +
"<div style='position:absolute;left:204.98px;top:334.67px' class='cls_010'><span class='cls_010'>evidence of clinical infection e.g. inflammation, redness,</span></div>" +
"<div style='position:absolute;left:467.33px;top:341.87px' class='cls_010'><span class='cls_010'>Flucloxacillin 500mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:341.87px' class='cls_010'><span class='cls_010'>Clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:72.00px;top:347.63px' class='cls_010'><span class='cls_010'>Leg Ulcers</span></div>" +
"<div style='position:absolute;left:204.98px;top:346.07px' class='cls_010'><span class='cls_010'>pyrexia, increased pain or enlarging ulcer. Send pre-</span></div>" +
"<div style='position:absolute;left:708.34px;top:347.63px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:353.39px' class='cls_010'><span class='cls_010'>QDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:353.39px' class='cls_010'><span class='cls_010'>BD</span></div>" +
"<div style='position:absolute;left:204.98px;top:357.59px' class='cls_010'><span class='cls_010'>treatment swab in active infection and review antibiotics</span></div>" +
"<div style='position:absolute;left:204.98px;top:369.11px' class='cls_010'><span class='cls_010'>after culture results. Refer for specialist opinion in</span></div>" +
"<div style='position:absolute;left:204.98px;top:380.63px' class='cls_010'><span class='cls_010'>severe infection e.g. diabetics.</span></div>" +
"<div style='position:absolute;left:204.98px;top:399.59px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/leg-ulcer-venous'>CKS - Leg Ulcers</A></div>" +
"<div style='position:absolute;left:204.98px;top:418.55px' class='cls_010'><span class='cls_010'>Antibiotic treatment is recommended if the woman has</span></div>" +
"<div style='position:absolute;left:204.98px;top:430.07px' class='cls_010'><span class='cls_010'>an infected nipple fissure, symptoms do not improve or</span></div>" +
"<div style='position:absolute;left:204.98px;top:441.59px' class='cls_010'><span class='cls_010'>are worsening after 12-24 hours despite effective milk</span></div>" +
"<div style='position:absolute;left:467.33px;top:447.35px' class='cls_010'><span class='cls_010'>Flucloxacillin 500mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:447.35px' class='cls_010'><span class='cls_010'>Erythromycin 250mg -</span></div>" +
"<div style='position:absolute;left:72.00px;top:453.11px' class='cls_010'><span class='cls_010'>Mastitis</span></div>" +
"<div style='position:absolute;left:204.98px;top:453.11px' class='cls_010'><span class='cls_010'>removal or bacterial culture is positive. Antibiotics</span></div>" +
"<div style='position:absolute;left:708.34px;top:453.11px' class='cls_010'><span class='cls_010'>14 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:458.78px' class='cls_010'><span class='cls_010'>QDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:458.78px' class='cls_010'><span class='cls_010'>500mg QDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:464.54px' class='cls_010'><span class='cls_010'>indicated are only excreted in very small amounts and</span></div>" +
"<div style='position:absolute;left:204.98px;top:476.06px' class='cls_010'><span class='cls_010'>the infant should not be affected but occasionally stools</span></div>" +
"<div style='position:absolute;left:204.98px;top:487.58px' class='cls_010'><span class='cls_010'>may be looser or more frequent or the infant may be</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>35</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:22159px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background36.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>more irritable. The woman should continue to breastfeed</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_010'><span class='cls_010'>and paracetamol can be used to relieve discomfort in</span></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_010'><span class='cls_010'>addition to warm compresses on the breast or a warm</span></div>" +
"<div style='position:absolute;left:204.98px;top:149.82px' class='cls_010'><span class='cls_010'>bath/shower.</span></div>" +
"<div style='position:absolute;left:204.98px;top:168.78px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/mastitis-and-breast-abscess'>CKS - Mastitis</A></div>" +
"<div style='position:absolute;left:587.71px;top:187.74px' class='cls_041'><span class='cls_041'>True penicillin allergy</span></div>" +
"<div style='position:absolute;left:204.98px;top:199.29px' class='cls_010'><span class='cls_010'>Consider treatment with antibiotics if cellulitis is</span></div>" +
"<div style='position:absolute;left:587.71px;top:199.29px' class='cls_010'><span class='cls_010'>Clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:210.81px' class='cls_010'><span class='cls_010'>suspected. Refer patients to a colorectal or general</span></div>" +
"<div style='position:absolute;left:587.71px;top:210.81px' class='cls_010'><span class='cls_010'>BD (or erythromycin</span></div>" +
"<div style='position:absolute;left:72.00px;top:216.45px' class='cls_010'><span class='cls_010'>Pilonidal sinus disease</span></div>" +
"<div style='position:absolute;left:467.33px;top:216.45px' class='cls_010'><span class='cls_010'>Flucloxacillin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:222.21px' class='cls_010'><span class='cls_010'>surgical unit for treatment, urgency depending on clinical</span></div>" +
"<div style='position:absolute;left:587.71px;top:222.21px' class='cls_010'><span class='cls_010'>500mg QDS if pregnant</span></div>" +
"<div style='position:absolute;left:708.34px;top:222.21px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:72.00px;top:227.97px' class='cls_010'><span class='cls_010'>(discharging)</span></div>" +
"<div style='position:absolute;left:467.33px;top:227.97px' class='cls_010'><span class='cls_010'>QDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:233.73px' class='cls_010'><span class='cls_010'>judgement. Offer paracetamol for pain and/or fever and</span></div>" +
"<div style='position:absolute;left:587.71px;top:233.73px' class='cls_010'><span class='cls_010'>or breastfeeding) PLUS</span></div>" +
"<div style='position:absolute;left:204.98px;top:245.25px' class='cls_010'><span class='cls_010'>consider NSAIDs if pain is not controlled.</span></div>" +
"<div style='position:absolute;left:587.71px;top:245.25px' class='cls_010'><span class='cls_010'>Metronidazole 400mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:256.77px' class='cls_010'><span class='cls_010'>TDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:275.73px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/pilonidal-sinus-disease'>CKS - Pilonidal sinus disease</A></div>" +
"<div style='position:absolute;left:467.33px;top:295.89px' class='cls_010'><span class='cls_010'>Flucloxacillin 500mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:295.89px' class='cls_010'><span class='cls_010'>Clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:467.33px;top:307.41px' class='cls_010'><span class='cls_010'>QDS (‘clean’ surgery)</span></div>" +
"<div style='position:absolute;left:587.71px;top:307.41px' class='cls_010'><span class='cls_010'>BD (penicillin allergy)</span></div>" +
"<div style='position:absolute;left:72.00px;top:319.17px' class='cls_010'><span class='cls_010'>Post-operative wound</span></div>" +
"<div style='position:absolute;left:467.33px;top:320.61px' class='cls_010'><span class='cls_010'>Co-amoxiclav</span><span class='cls_011'>♣</span><span class='cls_010'> 625mg</span></div>" +
"<div style='position:absolute;left:708.34px;top:319.17px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:324.95px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/lacerations#!scenario:2'>CKS - Infected laceration</A></div>" +
"<div style='position:absolute;left:587.71px;top:326.39px' class='cls_010'><span class='cls_010'>Clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:72.00px;top:330.71px' class='cls_010'><span class='cls_010'>infection</span></div>" +
"<div style='position:absolute;left:467.33px;top:332.15px' class='cls_010'><span class='cls_010'>TDS (contaminated</span></div>" +
"<div style='position:absolute;left:587.71px;top:337.91px' class='cls_010'><span class='cls_010'>BD plus Metronidazole</span></div>" +
"<div style='position:absolute;left:467.33px;top:343.67px' class='cls_010'><span class='cls_010'>abdominal or pelvic</span></div>" +
"<div style='position:absolute;left:587.71px;top:349.43px' class='cls_010'><span class='cls_010'>400mg TDS</span></div>" +
"<div style='position:absolute;left:467.33px;top:355.19px' class='cls_010'><span class='cls_010'>surgery)</span></div>" +
"<div style='position:absolute;left:204.98px;top:367.07px' class='cls_010'><span class='cls_010'>Panton-Valentine Leukocidin (PVL) is a toxin produced by 4.9% of </span><span class='cls_028'>S.aureus</span><span class='cls_010'> from boils/abscesses. The bacteria can rarely</span></div>" +
"<div style='position:absolute;left:72.00px;top:378.71px' class='cls_010'><span class='cls_010'>PVL</span></div>" +
"<div style='position:absolute;left:204.98px;top:378.71px' class='cls_010'><span class='cls_010'>cause severe invasive infections in healthy people. Send swabs if recurrent boils/abscesses. Risks: close contact in</span></div>" +
"<div style='position:absolute;left:204.98px;top:390.11px' class='cls_010'><span class='cls_010'>communities or sports, poor hygiene, eczema. </span><A HREF='https://www.gov.uk/government/uploads/system/uploads/attachment_data/file/391168/PVL_guidance_in_primary_care_quick_reference_guide.pdf'>PHE - PVL</A> </span></div>" +
"<div style='position:absolute;left:204.98px;top:402.11px' class='cls_010'><span class='cls_010'>Treat whole body from ear/chin downwards including</span></div>" +
"<div style='position:absolute;left:204.98px;top:413.63px' class='cls_010'><span class='cls_010'>under the nails. The very young, elderly and</span></div>" +
"<div style='position:absolute;left:204.98px;top:425.15px' class='cls_010'><span class='cls_010'>immunocompromised should also apply treatment to the</span></div>" +
"<div style='position:absolute;left:587.71px;top:425.15px' class='cls_010'><span class='cls_010'>Malathion 0.5%</span></div>" +
"<div style='position:absolute;left:467.33px;top:430.91px' class='cls_010'><span class='cls_010'>Permethrin 5% dermal</span></div>" +
"<div style='position:absolute;left:708.34px;top:430.91px' class='cls_010'><span class='cls_010'>Repeat after</span></div>" +
"<div style='position:absolute;left:72.00px;top:436.67px' class='cls_010'><span class='cls_010'>Scabies</span></div>" +
"<div style='position:absolute;left:204.98px;top:436.67px' class='cls_010'><span class='cls_010'>face and scalp. Treat ALL household and sexual</span></div>" +
"<div style='position:absolute;left:587.71px;top:436.67px' class='cls_010'><span class='cls_010'>aqueous liquid - in</span></div>" +
"<div style='position:absolute;left:467.33px;top:442.43px' class='cls_010'><span class='cls_010'>cream</span></div>" +
"<div style='position:absolute;left:708.34px;top:442.43px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:204.98px;top:448.19px' class='cls_010'><span class='cls_010'>contacts within 24 hours.</span></div>" +
"<div style='position:absolute;left:587.71px;top:448.19px' class='cls_010'><span class='cls_010'>permethrin allergy</span></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>36</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:22764px;width:841px;height:595px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background37.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:122.22px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/scabies'>CKS - Scabies</A></div>" +
"<div style='position:absolute;left:72.00px;top:148.14px' class='cls_023'><span class='cls_023'>VIRAL INFECTIONS</span></div>" +
"<div style='position:absolute;left:207.74px;top:167.22px' class='cls_010'><span class='cls_010'>If pregnant, immunocompromised or neonatal seek</span></div>" +
"<div style='position:absolute;left:204.98px;top:178.62px' class='cls_010'><span class='cls_010'>urgent specialist advice. Consider aciclovir if onset of</span></div>" +
"<div style='position:absolute;left:204.98px;top:190.14px' class='cls_010'><span class='cls_010'>rash is &lt; 24 hours </span><span class='cls_041'>and</span><span class='cls_010'> patient is over 14 years; or</span></div>" +
"<div style='position:absolute;left:204.98px;top:201.69px' class='cls_010'><span class='cls_010'>severe pain; or dense/oral rash; or secondary household</span></div>" +
"<div style='position:absolute;left:204.98px;top:213.21px' class='cls_010'><span class='cls_010'>case; or smoker. If patients develop life-threatening</span></div>" +
"<div style='position:absolute;left:204.98px;top:224.73px' class='cls_010'><span class='cls_010'>complications such as encephalitis, pneumonia or CNS</span></div>" +
"<div style='position:absolute;left:204.98px;top:236.25px' class='cls_010'><span class='cls_010'>deterioration they should be sent immediately to</span></div>" +
"<div style='position:absolute;left:204.98px;top:247.65px' class='cls_010'><span class='cls_010'>hospital. It is recommended that non-immune</span></div>" +
"<div style='position:absolute;left:467.33px;top:252.21px' class='cls_010'><span class='cls_010'>Aciclovir 800mg five</span></div>" +
"<div style='position:absolute;left:72.00px;top:257.97px' class='cls_010'><span class='cls_010'>Chicken Pox</span></div>" +
"<div style='position:absolute;left:204.98px;top:259.17px' class='cls_010'><span class='cls_010'>immunocompromised patients or pregnant women who</span></div>" +
"<div style='position:absolute;left:708.34px;top:257.97px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:263.73px' class='cls_010'><span class='cls_010'>times a day</span></div>" +
"<div style='position:absolute;left:204.98px;top:270.69px' class='cls_010'><span class='cls_010'>come into contact with chicken pox are given Varicella-</span></div>" +
"<div style='position:absolute;left:204.98px;top:282.21px' class='cls_010'><span class='cls_010'>Zoster immunoglobulin (VZIG) if they meet the criteria</span></div>" +
"<div style='position:absolute;left:204.98px;top:293.73px' class='cls_010'><span class='cls_010'>according to the current 'green' book. Supplies can be</span></div>" +
"<div style='position:absolute;left:204.98px;top:305.25px' class='cls_010'><span class='cls_010'>obtained from PHE Colindale on 020 8327 7471.</span></div>" +
"<div style='position:absolute;left:204.98px;top:338.75px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/chickenpox'>CKS - Chickenpox</A></div>" +
"<div style='position:absolute;left:204.98px;top:360.71px' class='cls_010'><span class='cls_010'>Counsel patient that treatment needs to be initiated at</span></div>" +
"<div style='position:absolute;left:204.98px;top:372.23px' class='cls_010'><span class='cls_010'>the onset of symptoms before vesicles appear and that</span></div>" +
"<div style='position:absolute;left:467.33px;top:377.03px' class='cls_010'><span class='cls_010'>Cold sores resolve after</span></div>" +
"<div style='position:absolute;left:204.98px;top:383.75px' class='cls_010'><span class='cls_010'>topical antivirals only affect the course of the current</span></div>" +
"<div style='position:absolute;left:467.33px;top:388.43px' class='cls_010'><span class='cls_010'>7-10 days without</span></div>" +
"<div style='position:absolute;left:204.98px;top:395.27px' class='cls_010'><span class='cls_010'>episode - they do not cure the individual or prevent</span></div>" +
"<div style='position:absolute;left:72.00px;top:399.95px' class='cls_010'><span class='cls_010'>Herpes Simplex (oral)</span></div>" +
"<div style='position:absolute;left:467.33px;top:399.95px' class='cls_010'><span class='cls_010'>treatment. Topical</span></div>" +
"<div style='position:absolute;left:587.71px;top:399.95px' class='cls_010'><span class='cls_010'>Aciclovir 5% topical</span></div>" +
"<div style='position:absolute;left:204.98px;top:406.79px' class='cls_010'><span class='cls_010'>further recurrence.</span></div>" +
"<div style='position:absolute;left:708.34px;top:405.71px' class='cls_010'><span class='cls_010'>5 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:411.47px' class='cls_010'><span class='cls_010'>antivirals applied</span></div>" +
"<div style='position:absolute;left:587.71px;top:411.47px' class='cls_010'><span class='cls_010'>cream five times a day</span></div>" +
"<div style='position:absolute;left:467.33px;top:422.99px' class='cls_010'><span class='cls_010'>prodromally reduce</span></div>" +
"<div style='position:absolute;left:467.33px;top:434.51px' class='cls_010'><span class='cls_010'>duration by 12-24 hours.</span></div>" +
"<div style='position:absolute;left:204.98px;top:446.27px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/herpes-simplex-oral'>CKS - Herpes</A></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>37</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-420px;top:23369px;width:841px;height:595px;border-style:outset;overflow:hidden'>" + 
"<div style='position:absolute;left:0px;top:0px'>" + 
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background38.jpg' width=841 height=595></div>" +
"<div style='position:absolute;left:72.00px;top:96.18px' class='cls_009'><span class='cls_009'>Infection</span></div>" +
"<div style='position:absolute;left:204.98px;top:96.18px' class='cls_009'><span class='cls_009'>Rationale/Comments</span></div>" +
"<div style='position:absolute;left:467.33px;top:96.18px' class='cls_009'><span class='cls_009'>1st Line Choice</span></div>" +
"<div style='position:absolute;left:587.71px;top:96.18px' class='cls_009'><span class='cls_009'>2nd Line Choice</span></div>" +
"<div style='position:absolute;left:708.34px;top:96.18px' class='cls_009'><span class='cls_009'>Duration</span></div>" +
"<div style='position:absolute;left:204.98px;top:115.26px' class='cls_010'><span class='cls_010'>If pregnant or immunocompromised, seek urgent</span></div>" +
"<div style='position:absolute;left:587.71px;top:120.42px' class='cls_010'><span class='cls_010'>Valaciclovir 1g TDS or</span></div>" +
"<div style='position:absolute;left:204.98px;top:126.78px' class='cls_010'><span class='cls_010'>specialist advice. Treat if over 50 years and within 72</span></div>" +
"<div style='position:absolute;left:587.71px;top:131.94px' class='cls_010'><span class='cls_010'>famciclovir 500mg TDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:138.30px' class='cls_010'><span class='cls_010'>hours of the rash or if there is active ophthalmic</span></div>" +
"<div style='position:absolute;left:587.71px;top:143.46px' class='cls_010'><span class='cls_010'>or famciclovir 750mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:149.82px' class='cls_010'><span class='cls_010'>infection, non- truncal involvement, moderate/severe</span></div>" +
"<div style='position:absolute;left:587.71px;top:154.98px' class='cls_010'><span class='cls_010'>OD</span></div>" +
"<div style='position:absolute;left:204.98px;top:161.22px' class='cls_010'><span class='cls_010'>pain or rash.</span></div>" +
"<div style='position:absolute;left:467.33px;top:160.74px' class='cls_010'><span class='cls_010'>Aciclovir 800mg five</span></div>" +
"<div style='position:absolute;left:72.00px;top:166.50px' class='cls_010'><span class='cls_010'>Shingles</span></div>" +
"<div style='position:absolute;left:587.71px;top:166.50px' class='cls_041'><span class='cls_041'>Use if compliance is a</span></div>" +
"<div style='position:absolute;left:708.34px;top:166.50px' class='cls_010'><span class='cls_010'>7 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:172.26px' class='cls_010'><span class='cls_010'>times a day</span></div>" +
"<div style='position:absolute;left:587.71px;top:177.90px' class='cls_041'><span class='cls_041'>problem because cost is</span></div>" +
"<div style='position:absolute;left:587.71px;top:189.42px' class='cls_041'><span class='cls_041'>considerably greater</span></div>" +
"<div style='position:absolute;left:587.71px;top:200.97px' class='cls_041'><span class='cls_041'>than aciclovir</span></div>" +
"<div style='position:absolute;left:204.98px;top:206.97px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/shingles'>CKS - Shingles</A></div>" +
"<div style='position:absolute;left:72.00px;top:236.49px' class='cls_023'><span class='cls_023'>DENTAL INFECTIONS</span></div>" +
"<div style='position:absolute;left:204.98px;top:266.97px' class='cls_010'><span class='cls_010'>Advise the patient to seek treatment from a dental</span></div>" +
"<div style='position:absolute;left:204.98px;top:278.49px' class='cls_010'><span class='cls_010'>practitioner. Only prescribe an antibiotic for patients who</span></div>" +
"<div style='position:absolute;left:467.33px;top:278.01px' class='cls_010'><span class='cls_010'>Amoxicillin 500mg TDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:290.01px' class='cls_010'><span class='cls_010'>are systemically unwell or if there are signs of severe</span></div>" +
"<div style='position:absolute;left:467.33px;top:289.53px' class='cls_010'><span class='cls_010'>or</span></div>" +
"<div style='position:absolute;left:587.71px;top:289.53px' class='cls_010'><span class='cls_010'>Clarithromycin 500mg</span></div>" +
"<div style='position:absolute;left:204.98px;top:301.53px' class='cls_010'><span class='cls_010'>infection such as fever, lymphadenopathy, cellulitis or</span></div>" +
"<div style='position:absolute;left:467.33px;top:301.05px' class='cls_010'><span class='cls_010'>phenoxymethylpenicillin</span></div>" +
"<div style='position:absolute;left:587.71px;top:301.05px' class='cls_010'><span class='cls_010'>BD (penicillin allergy)</span></div>" +
"<div style='position:absolute;left:204.98px;top:312.93px' class='cls_010'><span class='cls_010'>diffuse swelling or if there is a high risk of complications.</span></div>" +
"<div style='position:absolute;left:467.33px;top:312.45px' class='cls_010'><span class='cls_010'>500mg - 1G QDS</span></div>" +
"<div style='position:absolute;left:587.71px;top:312.45px' class='cls_010'><span class='cls_010'>In severe or spreading</span></div>" +
"<div style='position:absolute;left:72.00px;top:318.21px' class='cls_010'><span class='cls_010'>Dental Abscess</span></div>" +
"<div style='position:absolute;left:708.34px;top:318.21px' class='cls_010'><span class='cls_010'>5 days</span></div>" +
"<div style='position:absolute;left:467.33px;top:323.99px' class='cls_010'><span class='cls_010'>In severe or spreading</span></div>" +
"<div style='position:absolute;left:587.71px;top:323.99px' class='cls_010'><span class='cls_010'>infection add</span></div>" +
"<div style='position:absolute;left:467.33px;top:335.51px' class='cls_010'><span class='cls_010'>infection add</span></div>" +
"<div style='position:absolute;left:587.71px;top:335.51px' class='cls_010'><span class='cls_010'>metronidazole 400mg</span></div>" +
"<div style='position:absolute;left:467.33px;top:347.03px' class='cls_010'><span class='cls_010'>metronidazole 400mg</span></div>" +
"<div style='position:absolute;left:587.71px;top:347.03px' class='cls_010'><span class='cls_010'>TDS</span></div>" +
"<div style='position:absolute;left:467.33px;top:358.55px' class='cls_010'><span class='cls_010'>TDS</span></div>" +
"<div style='position:absolute;left:204.98px;top:370.19px' class='cls_040'><span class='cls_040'> </span><A HREF='http://cks.nice.org.uk/dental-abscess'>CKS - Dental abscess</A></div>" +
"<div style='position:absolute;left:72.00px;top:531.02px' class='cls_002'><span class='cls_002'>NOTE: Doses are oral and for adults with normal hepatic/renal function unless otherwise stated. Please refer to latest BNF for</span></div>" +
"<div style='position:absolute;left:756.58px;top:531.14px' class='cls_002'><span class='cls_002'>38</span></div>" +
"<div style='position:absolute;left:72.00px;top:544.82px' class='cls_002'><span class='cls_002'>further prescribing information. Published date: July 2015</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-297px;top:23974px;width:595px;height:841px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background39.jpg' width=595 height=841></div>" +
"<div style='position:absolute;left:54.00px;top:70.12px' class='cls_034'><span class='cls_034'>Appendix 1</span></div>" +
"<div style='position:absolute;left:87.98px;top:97.62px' class='cls_003'><span class='cls_003'>MANAGEMENT OF SUSPECTED UTI IN WOMEN (Not Pregnant)</span></div>" +
"<div style='position:absolute;left:231.41px;top:146.70px' class='cls_010'><span class='cls_010'>Signs and symptoms of UTI?</span></div>" +
"<div style='position:absolute;left:244.85px;top:158.94px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:267.41px;top:158.94px' class='cls_010'><span class='cls_010'>dysuria</span></div>" +
"<div style='position:absolute;left:244.85px;top:172.86px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:267.41px;top:172.86px' class='cls_010'><span class='cls_010'>urgency</span></div>" +
"<div style='position:absolute;left:244.85px;top:186.78px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:267.41px;top:186.78px' class='cls_010'><span class='cls_010'>frequency</span></div>" +
"<div style='position:absolute;left:244.85px;top:200.70px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:267.41px;top:200.70px' class='cls_010'><span class='cls_010'>polyuria</span></div>" +
"<div style='position:absolute;left:244.85px;top:214.50px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:267.41px;top:214.50px' class='cls_010'><span class='cls_010'>suprapubic tenderness</span></div>" +
"<div style='position:absolute;left:244.85px;top:228.42px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:267.41px;top:228.42px' class='cls_010'><span class='cls_010'>fever</span></div>" +
"<div style='position:absolute;left:54.72px;top:237.06px' class='cls_010'><span class='cls_010'>Severe or 3 or more</span></div>" +
"<div style='position:absolute;left:244.85px;top:242.34px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:267.41px;top:242.34px' class='cls_010'><span class='cls_010'>flank or back pain</span></div>" +
"<div style='position:absolute;left:54.72px;top:248.58px' class='cls_010'><span class='cls_010'>symptoms</span></div>" +
"<div style='position:absolute;left:465.79px;top:252.30px' class='cls_010'><span class='cls_010'>Vaginal itch or</span></div>" +
"<div style='position:absolute;left:465.79px;top:263.82px' class='cls_010'><span class='cls_010'>discharge ?</span></div>" +
"<div style='position:absolute;left:238.97px;top:269.94px' class='cls_010'><span class='cls_010'>Limited (no more than two) symptoms</span></div>" +
"<div style='position:absolute;left:31.32px;top:291.45px' class='cls_010'><span class='cls_010'>Signs & symptoms of UUTI:</span></div>" +
"<div style='position:absolute;left:44.76px;top:303.69px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:67.34px;top:303.69px' class='cls_010'><span class='cls_010'>loin pain</span></div>" +
"<div style='position:absolute;left:44.76px;top:317.61px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:67.34px;top:317.61px' class='cls_010'><span class='cls_010'>flank tenderness</span></div>" +
"<div style='position:absolute;left:465.91px;top:321.69px' class='cls_010'><span class='cls_010'>Explore alternative</span></div>" +
"<div style='position:absolute;left:44.76px;top:331.53px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:67.34px;top:331.53px' class='cls_010'><span class='cls_010'>fever</span></div>" +
"<div style='position:absolute;left:465.91px;top:333.21px' class='cls_010'><span class='cls_010'>diagnoses and</span></div>" +
"<div style='position:absolute;left:238.97px;top:337.53px' class='cls_010'><span class='cls_010'>Use dipstick tests to guide treatment</span></div>" +
"<div style='position:absolute;left:44.76px;top:345.33px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:67.34px;top:345.33px' class='cls_010'><span class='cls_010'>rigors</span></div>" +
"<div style='position:absolute;left:465.91px;top:344.73px' class='cls_010'><span class='cls_010'>consider pelvic</span></div>" +
"<div style='position:absolute;left:238.97px;top:349.05px' class='cls_010'><span class='cls_010'>decisions in otherwise healthy women</span></div>" +
"<div style='position:absolute;left:465.91px;top:356.25px' class='cls_010'><span class='cls_010'>examination</span></div>" +
"<div style='position:absolute;left:44.76px;top:359.25px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:67.34px;top:359.25px' class='cls_010'><span class='cls_010'>other manifestations of</span></div>" +
"<div style='position:absolute;left:238.97px;top:360.57px' class='cls_010'><span class='cls_010'>under 65 years of age presenting with mild</span></div>" +
"<div style='position:absolute;left:67.34px;top:372.57px' class='cls_010'><span class='cls_010'>systemic inflammatory</span></div>" +
"<div style='position:absolute;left:238.97px;top:372.09px' class='cls_010'><span class='cls_010'>or ≤ 2 symptoms of UTI</span></div>" +
"<div style='position:absolute;left:67.34px;top:385.53px' class='cls_010'><span class='cls_010'>response</span></div>" +
"<div style='position:absolute;left:273.77px;top:422.85px' class='cls_010'><span class='cls_010'>Dipstick positive</span></div>" +
"<div style='position:absolute;left:385.39px;top:423.57px' class='cls_010'><span class='cls_010'>Dipstick negative</span></div>" +
"<div style='position:absolute;left:30.84px;top:425.25px' class='cls_010'><span class='cls_010'>UUTI can be accompanied by</span></div>" +
"<div style='position:absolute;left:30.84px;top:436.77px' class='cls_010'><span class='cls_010'>bacteraemia, making it a life-</span></div>" +
"<div style='position:absolute;left:385.39px;top:435.09px' class='cls_010'><span class='cls_010'>or equivocal</span></div>" +
"<div style='position:absolute;left:30.84px;top:448.29px' class='cls_010'><span class='cls_010'>threatening condition</span></div>" +
"<div style='position:absolute;left:195.86px;top:445.41px' class='cls_007'><span class='cls_007'>NO</span></div>" +
"<div style='position:absolute;left:270.05px;top:478.91px' class='cls_010'><span class='cls_010'>Treat non-</span></div>" +
"<div style='position:absolute;left:385.51px;top:479.99px' class='cls_010'><span class='cls_010'>Discuss the risks</span></div>" +
"<div style='position:absolute;left:90.86px;top:482.63px' class='cls_007'><span class='cls_007'>YES</span></div>" +
"<div style='position:absolute;left:270.05px;top:490.43px' class='cls_010'><span class='cls_010'>pregnant women</span></div>" +
"<div style='position:absolute;left:385.51px;top:491.39px' class='cls_010'><span class='cls_010'>and benefits of</span></div>" +
"<div style='position:absolute;left:54.60px;top:502.67px' class='cls_010'><span class='cls_010'>Systemic symptoms?</span></div>" +
"<div style='position:absolute;left:270.05px;top:501.83px' class='cls_010'><span class='cls_010'>with symptoms or</span></div>" +
"<div style='position:absolute;left:385.51px;top:502.91px' class='cls_010'><span class='cls_010'>empirical treatment</span></div>" +
"<div style='position:absolute;left:270.05px;top:513.35px' class='cls_010'><span class='cls_010'>signs of acute</span></div>" +
"<div style='position:absolute;left:385.51px;top:514.43px' class='cls_010'><span class='cls_010'>with the patient and</span></div>" +
"<div style='position:absolute;left:54.00px;top:521.75px' class='cls_007'><span class='cls_007'>NO</span></div>" +
"<div style='position:absolute;left:164.78px;top:521.75px' class='cls_007'><span class='cls_007'>YES</span></div>" +
"<div style='position:absolute;left:270.05px;top:524.87px' class='cls_010'><span class='cls_010'>LUTI with</span></div>" +
"<div style='position:absolute;left:385.51px;top:525.95px' class='cls_010'><span class='cls_010'>manage treatment</span></div>" +
"<div style='position:absolute;left:270.05px;top:536.39px' class='cls_010'><span class='cls_010'>antibiotics</span></div>" +
"<div style='position:absolute;left:385.51px;top:537.47px' class='cls_010'><span class='cls_010'>accordingly</span></div>" +
"<div style='position:absolute;left:14.64px;top:542.63px' class='cls_010'><span class='cls_010'>Where hospital</span></div>" +
"<div style='position:absolute;left:146.78px;top:541.79px' class='cls_010'><span class='cls_010'>Consider</span></div>" +
"<div style='position:absolute;left:270.05px;top:547.91px' class='cls_010'><span class='cls_010'>according to local</span></div>" +
"<div style='position:absolute;left:14.64px;top:554.03px' class='cls_010'><span class='cls_010'>admission is not</span></div>" +
"<div style='position:absolute;left:146.78px;top:553.31px' class='cls_010'><span class='cls_010'>admission to</span></div>" +
"<div style='position:absolute;left:270.05px;top:559.43px' class='cls_010'><span class='cls_010'>guidelines</span></div>" +
"<div style='position:absolute;left:14.64px;top:565.55px' class='cls_010'><span class='cls_010'>required, take a</span></div>" +
"<div style='position:absolute;left:146.78px;top:564.83px' class='cls_010'><span class='cls_010'>hospital</span></div>" +
"<div style='position:absolute;left:14.64px;top:577.07px' class='cls_010'><span class='cls_010'>midstream urine</span></div>" +
"<div style='position:absolute;left:385.51px;top:576.83px' class='cls_010'><span class='cls_010'>Investigate other</span></div>" +
"<div style='position:absolute;left:14.64px;top:588.59px' class='cls_010'><span class='cls_010'>sample for culture and</span></div>" +
"<div style='position:absolute;left:385.51px;top:588.35px' class='cls_010'><span class='cls_010'>potential causes in</span></div>" +
"<div style='position:absolute;left:269.69px;top:596.63px' class='cls_010'><span class='cls_010'>Take urine for</span></div>" +
"<div style='position:absolute;left:14.64px;top:600.11px' class='cls_010'><span class='cls_010'>begin a course of</span></div>" +
"<div style='position:absolute;left:385.51px;top:599.87px' class='cls_010'><span class='cls_010'>women who remain</span></div>" +
"<div style='position:absolute;left:269.69px;top:608.03px' class='cls_010'><span class='cls_010'>culture to guide</span></div>" +
"<div style='position:absolute;left:14.64px;top:611.63px' class='cls_010'><span class='cls_010'>antibiotics.</span></div>" +
"<div style='position:absolute;left:385.51px;top:611.27px' class='cls_010'><span class='cls_010'>symptomatic after a</span></div>" +
"<div style='position:absolute;left:269.69px;top:619.55px' class='cls_010'><span class='cls_010'>change of</span></div>" +
"<div style='position:absolute;left:385.51px;top:622.79px' class='cls_010'><span class='cls_010'>single course of</span></div>" +
"<div style='position:absolute;left:269.69px;top:631.07px' class='cls_010'><span class='cls_010'>antibiotic for</span></div>" +
"<div style='position:absolute;left:385.51px;top:634.19px' class='cls_010'><span class='cls_010'>treatment</span></div>" +
"<div style='position:absolute;left:269.69px;top:642.59px' class='cls_010'><span class='cls_010'>patients who do</span></div>" +
"<div style='position:absolute;left:14.52px;top:646.55px' class='cls_010'><span class='cls_010'>Treat non-pregnant</span></div>" +
"<div style='position:absolute;left:269.69px;top:654.14px' class='cls_010'><span class='cls_010'>not respond to</span></div>" +
"<div style='position:absolute;left:14.52px;top:658.10px' class='cls_010'><span class='cls_010'>women with symptoms</span></div>" +
"<div style='position:absolute;left:269.69px;top:665.66px' class='cls_010'><span class='cls_010'>initial treatment</span></div>" +
"<div style='position:absolute;left:14.52px;top:669.50px' class='cls_010'><span class='cls_010'>or signs of acute UUTI</span></div>" +
"<div style='position:absolute;left:14.52px;top:681.02px' class='cls_010'><span class='cls_010'>with antibiotics as</span></div>" +
"<div style='position:absolute;left:14.52px;top:692.54px' class='cls_010'><span class='cls_010'>recommended in local</span></div>" +
"<div style='position:absolute;left:14.52px;top:703.94px' class='cls_010'><span class='cls_010'>guidelines</span></div>" +
"<div style='position:absolute;left:271.13px;top:715.58px' class='cls_010'><span class='cls_010'>Advise women</span></div>" +
"<div style='position:absolute;left:271.13px;top:727.10px' class='cls_010'><span class='cls_010'>with LUTI, who</span></div>" +
"<div style='position:absolute;left:14.52px;top:738.98px' class='cls_010'><span class='cls_010'>Admit the patient to</span></div>" +
"<div style='position:absolute;left:271.13px;top:738.62px' class='cls_010'><span class='cls_010'>are prescribed</span></div>" +
"<div style='position:absolute;left:14.52px;top:750.50px' class='cls_010'><span class='cls_010'>hospital if there is no</span></div>" +
"<div style='position:absolute;left:271.13px;top:750.02px' class='cls_010'><span class='cls_010'>nitrofurantoin, </span><span class='cls_009'>not</span></div>" +
"<div style='position:absolute;left:14.52px;top:762.02px' class='cls_010'><span class='cls_010'>response to the</span></div>" +
"<div style='position:absolute;left:271.13px;top:761.54px' class='cls_009'><span class='cls_009'>to</span><span class='cls_010'> take alkalising</span></div>" +
"<div style='position:absolute;left:445.75px;top:772.70px' class='cls_012'><span class='cls_012'>Reproduced from</span></div>" +
"<div style='position:absolute;left:14.52px;top:773.54px' class='cls_010'><span class='cls_010'>antibiotic within 24</span></div>" +
"<div style='position:absolute;left:271.13px;top:773.06px' class='cls_010'><span class='cls_010'>agents (such as</span></div>" +
"<div style='position:absolute;left:445.75px;top:781.94px' class='cls_012'><span class='cls_012'>SIGN88</span></div>" +
"<div style='position:absolute;left:528.10px;top:777.02px' class='cls_002'><span class='cls_002'>39</span></div>" +
"<div style='position:absolute;left:14.52px;top:785.06px' class='cls_010'><span class='cls_010'>hours</span></div>" +
"<div style='position:absolute;left:271.13px;top:784.46px' class='cls_010'><span class='cls_010'>potassium citrate)</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-297px;top:24825px;width:595px;height:841px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background40.jpg' width=595 height=841></div>" +
"<div style='position:absolute;left:54.00px;top:70.12px' class='cls_034'><span class='cls_034'>Appendix 2</span></div>" +
"<div style='position:absolute;left:124.94px;top:97.62px' class='cls_003'><span class='cls_003'>MANAGEMENT OF SUSPECTED UTI IN ADULT MEN</span></div>" +
"<div style='position:absolute;left:181.22px;top:169.98px' class='cls_002'><span class='cls_002'>Symptoms and signs of UTI</span></div>" +
"<div style='position:absolute;left:199.22px;top:184.62px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   dysuria</span></div>" +
"<div style='position:absolute;left:199.22px;top:201.30px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   urgency</span></div>" +
"<div style='position:absolute;left:199.22px;top:217.98px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   frequency</span></div>" +
"<div style='position:absolute;left:199.22px;top:234.66px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   polyuria</span></div>" +
"<div style='position:absolute;left:199.22px;top:251.46px' class='cls_017'><span class='cls_017'></span><span class='cls_002'>   suprapubic  tenderness</span></div>" +
"<div style='position:absolute;left:181.22px;top:307.41px' class='cls_005'><span class='cls_005'>Differential diagnosis should</span></div>" +
"<div style='position:absolute;left:181.22px;top:321.21px' class='cls_005'><span class='cls_005'>include acute prostatitis,</span></div>" +
"<div style='position:absolute;left:181.22px;top:335.01px' class='cls_005'><span class='cls_005'>chlamydial infection, epididymitis</span></div>" +
"<div style='position:absolute;left:181.46px;top:380.01px' class='cls_002'><span class='cls_002'>In all men with symptoms of UTI a</span></div>" +
"<div style='position:absolute;left:181.46px;top:393.81px' class='cls_002'><span class='cls_002'>urine sample should be taken for</span></div>" +
"<div style='position:absolute;left:181.46px;top:407.61px' class='cls_002'><span class='cls_002'>culture</span></div>" +
"<div style='position:absolute;left:80.66px;top:510.23px' class='cls_010'><span class='cls_010'>Recurrent UTI or failure to</span></div>" +
"<div style='position:absolute;left:339.43px;top:510.47px' class='cls_010'><span class='cls_010'>History of fever or back pain?</span></div>" +
"<div style='position:absolute;left:80.66px;top:521.75px' class='cls_010'><span class='cls_010'>respond to treatment</span></div>" +
"<div style='position:absolute;left:342.91px;top:592.67px' class='cls_007'><span class='cls_007'>YES</span></div>" +
"<div style='position:absolute;left:477.70px;top:592.67px' class='cls_007'><span class='cls_007'>NO</span></div>" +
"<div style='position:absolute;left:80.18px;top:625.91px' class='cls_010'><span class='cls_010'>Refer for urological</span></div>" +
"<div style='position:absolute;left:280.01px;top:625.79px' class='cls_010'><span class='cls_010'>Consider the possibility of</span></div>" +
"<div style='position:absolute;left:432.43px;top:625.67px' class='cls_010'><span class='cls_010'>Treat as uncomplicated</span></div>" +
"<div style='position:absolute;left:80.18px;top:637.43px' class='cls_010'><span class='cls_010'>investigation</span></div>" +
"<div style='position:absolute;left:280.01px;top:637.07px' class='cls_010'><span class='cls_010'>UUTI</span></div>" +
"<div style='position:absolute;left:432.43px;top:637.19px' class='cls_010'><span class='cls_010'>lower UTI according to</span></div>" +
"<div style='position:absolute;left:432.43px;top:648.71px' class='cls_010'><span class='cls_010'>local guidelines</span></div>" +
"<div style='position:absolute;left:280.97px;top:679.22px' class='cls_010'><span class='cls_010'>Treat men with symptoms</span></div>" +
"<div style='position:absolute;left:280.97px;top:690.74px' class='cls_010'><span class='cls_010'>suggestive of prostatitis</span></div>" +
"<div style='position:absolute;left:280.97px;top:702.26px' class='cls_010'><span class='cls_010'>empirically in line with</span></div>" +
"<div style='position:absolute;left:280.97px;top:713.66px' class='cls_010'><span class='cls_010'>local guidelines</span></div>" +
"<div style='position:absolute;left:54.00px;top:740.30px' class='cls_012'><span class='cls_012'>Reproduced from SIGN 88</span></div>" +
"<div style='position:absolute;left:528.10px;top:777.02px' class='cls_002'><span class='cls_002'>40</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-297px;top:25676px;width:595px;height:841px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background41.jpg' width=595 height=841></div>" +
"<div style='position:absolute;left:54.00px;top:70.12px' class='cls_043'><span class='cls_043'>Appendix 3</span></div>" +
"<div style='position:absolute;left:83.30px;top:94.62px' class='cls_003'><span class='cls_003'>DIAGNOSIS AND MANAGEMENT OF SUSPECTED UTI IN OLDER</span></div>" +
"<div style='position:absolute;left:208.97px;top:113.10px' class='cls_003'><span class='cls_003'>PEOPLE Over 65 years old</span></div>" +
"<div style='position:absolute;left:54.00px;top:141.78px' class='cls_032'><span class='cls_032'>Decision aid to guide management of patients/residents with fever defined as temperature >37.9ºC</span></div>" +
"<div style='position:absolute;left:54.00px;top:154.50px' class='cls_032'><span class='cls_032'>or 1.5ºC increase above baseline occurring on at least two occasions in last 12 hours.</span></div>" +
"<div style='position:absolute;left:54.00px;top:167.10px' class='cls_032'><span class='cls_032'>Hypothermia (low temperature of &lt;36ºC) may also indicate infection, especially those with</span></div>" +
"<div style='position:absolute;left:54.00px;top:179.82px' class='cls_032'><span class='cls_032'>comorbidities.</span></div>" +
"<div style='position:absolute;left:54.00px;top:192.42px' class='cls_032'><span class='cls_032'>Be alert to non-specific symptoms of infection such as abdominal pain, alteration of behaviour or</span></div>" +
"<div style='position:absolute;left:54.00px;top:205.02px' class='cls_032'><span class='cls_032'>loss of diabetes control.</span></div>" +
"<div style='position:absolute;left:189.50px;top:228.30px' class='cls_009'><span class='cls_009'>Are there any symptoms suggestive of non-urinary infection?</span></div>" +
"<div style='position:absolute;left:63.96px;top:249.30px' class='cls_010'><span class='cls_010'>Manage</span></div>" +
"<div style='position:absolute;left:189.50px;top:251.34px' class='cls_009'><span class='cls_009'>Respiratory</span><span class='cls_010'> - shortness of breath, cough or sputum production, new</span></div>" +
"<div style='position:absolute;left:63.96px;top:260.82px' class='cls_010'><span class='cls_010'>following local</span></div>" +
"<div style='position:absolute;left:189.50px;top:262.98px' class='cls_010'><span class='cls_010'>pleuritic chest pain</span></div>" +
"<div style='position:absolute;left:63.96px;top:272.37px' class='cls_010'><span class='cls_010'>antibiotic policy</span></div>" +
"<div style='position:absolute;left:189.50px;top:274.29px' class='cls_009'><span class='cls_009'>Gastrointestinal</span><span class='cls_010'> - nausea/vomiting, new abdominal pain, new onset</span></div>" +
"<div style='position:absolute;left:189.50px;top:285.93px' class='cls_010'><span class='cls_010'>diarrhoea</span></div>" +
"<div style='position:absolute;left:189.50px;top:297.33px' class='cls_009'><span class='cls_009'>Skin/soft tissue</span><span class='cls_010'>-new redness, warmth, swelling, purulent drainage</span></div>" +
"<div style='position:absolute;left:267.53px;top:348.69px' class='cls_002'><span class='cls_002'>NO</span></div>" +
"<div style='position:absolute;left:114.14px;top:362.61px' class='cls_002'><span class='cls_002'>YES</span></div>" +
"<div style='position:absolute;left:368.83px;top:362.61px' class='cls_002'><span class='cls_002'>NO</span></div>" +
"<div style='position:absolute;left:173.66px;top:367.41px' class='cls_010'><span class='cls_010'>Does the patient/resident have a</span></div>" +
"<div style='position:absolute;left:173.66px;top:378.81px' class='cls_010'><span class='cls_010'>urinary catheter?</span></div>" +
"<div style='position:absolute;left:92.42px;top:408.81px' class='cls_010'><span class='cls_010'>Does patient/resident</span></div>" +
"<div style='position:absolute;left:326.81px;top:410.01px' class='cls_010'><span class='cls_010'>Does patient/resident have</span></div>" +
"<div style='position:absolute;left:92.42px;top:420.33px' class='cls_010'><span class='cls_010'>have one or more of</span></div>" +
"<div style='position:absolute;left:326.81px;top:421.53px' class='cls_010'><span class='cls_010'>one or more of following</span></div>" +
"<div style='position:absolute;left:92.42px;top:431.85px' class='cls_010'><span class='cls_010'>following symptoms?</span></div>" +
"<div style='position:absolute;left:326.81px;top:433.05px' class='cls_010'><span class='cls_010'>symptoms?</span></div>" +
"<div style='position:absolute;left:110.42px;top:443.97px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:128.42px;top:443.97px' class='cls_010'><span class='cls_010'>shaking chills</span></div>" +
"<div style='position:absolute;left:344.83px;top:445.29px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    dysuria</span></div>" +
"<div style='position:absolute;left:128.42px;top:457.29px' class='cls_010'><span class='cls_010'>(rigors)</span></div>" +
"<div style='position:absolute;left:344.83px;top:457.41px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    urgency</span></div>" +
"<div style='position:absolute;left:54.00px;top:464.03px' class='cls_002'><span class='cls_002'>NO</span></div>" +
"<div style='position:absolute;left:228.17px;top:464.03px' class='cls_002'><span class='cls_002'>YES</span></div>" +
"<div style='position:absolute;left:286.85px;top:464.03px' class='cls_002'><span class='cls_002'>YES</span></div>" +
"<div style='position:absolute;left:486.10px;top:464.03px' class='cls_002'><span class='cls_002'>NO</span></div>" +
"<div style='position:absolute;left:110.42px;top:471.11px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:128.42px;top:471.11px' class='cls_010'><span class='cls_010'>new</span></div>" +
"<div style='position:absolute;left:344.83px;top:469.67px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    urinary</span></div>" +
"<div style='position:absolute;left:362.83px;top:481.07px' class='cls_010'><span class='cls_010'>incontinence</span></div>" +
"<div style='position:absolute;left:128.42px;top:484.43px' class='cls_010'><span class='cls_010'>costovertebral</span></div>" +
"<div style='position:absolute;left:344.83px;top:493.31px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    shaking chills</span></div>" +
"<div style='position:absolute;left:128.42px;top:497.75px' class='cls_010'><span class='cls_010'>tenderness</span></div>" +
"<div style='position:absolute;left:362.83px;top:504.71px' class='cls_010'><span class='cls_010'>(rigors)</span></div>" +
"<div style='position:absolute;left:110.42px;top:511.55px' class='cls_026'><span class='cls_026'></span></div>" +
"<div style='position:absolute;left:128.42px;top:511.55px' class='cls_010'><span class='cls_010'>new onset</span></div>" +
"<div style='position:absolute;left:344.83px;top:516.95px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    flank or suprapubic</span></div>" +
"<div style='position:absolute;left:128.42px;top:524.87px' class='cls_010'><span class='cls_010'>delirium</span></div>" +
"<div style='position:absolute;left:362.83px;top:528.47px' class='cls_010'><span class='cls_010'>pain</span></div>" +
"<div style='position:absolute;left:344.83px;top:540.71px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    frank haematuria</span></div>" +
"<div style='position:absolute;left:344.83px;top:552.83px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    new onset or</span></div>" +
"<div style='position:absolute;left:362.83px;top:564.23px' class='cls_010'><span class='cls_010'>worsening of re-</span></div>" +
"<div style='position:absolute;left:19.44px;top:570.83px' class='cls_010'><span class='cls_010'>UTI unlikely but</span></div>" +
"<div style='position:absolute;left:485.26px;top:570.95px' class='cls_010'><span class='cls_010'>UTI unlikely</span></div>" +
"<div style='position:absolute;left:362.83px;top:575.75px' class='cls_010'><span class='cls_010'>existing</span></div>" +
"<div style='position:absolute;left:19.44px;top:582.23px' class='cls_010'><span class='cls_010'>continue to</span></div>" +
"<div style='position:absolute;left:485.26px;top:582.47px' class='cls_010'><span class='cls_010'>but continue</span></div>" +
"<div style='position:absolute;left:232.01px;top:583.55px' class='cls_005'><span class='cls_005'>UTI likely</span></div>" +
"<div style='position:absolute;left:362.83px;top:587.15px' class='cls_010'><span class='cls_010'>confusion/agitation</span></div>" +
"<div style='position:absolute;left:19.44px;top:593.75px' class='cls_010'><span class='cls_010'>monitor</span></div>" +
"<div style='position:absolute;left:485.26px;top:593.99px' class='cls_010'><span class='cls_010'>to monitor</span></div>" +
"<div style='position:absolute;left:19.44px;top:605.27px' class='cls_010'><span class='cls_010'>symptoms</span></div>" +
"<div style='position:absolute;left:485.26px;top:605.51px' class='cls_010'><span class='cls_010'>symptoms</span></div>" +
"<div style='position:absolute;left:19.44px;top:616.79px' class='cls_010'><span class='cls_010'>Encourage</span></div>" +
"<div style='position:absolute;left:19.44px;top:628.31px' class='cls_010'><span class='cls_010'>improved fluid</span></div>" +
"<div style='position:absolute;left:19.44px;top:639.71px' class='cls_010'><span class='cls_010'>intake</span></div>" +
"<div style='position:absolute;left:132.74px;top:642.71px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    Assess if retention or sub-acute retention of urine is likely (e.g. blocked</span></div>" +
"<div style='position:absolute;left:150.74px;top:654.26px' class='cls_010'><span class='cls_010'>catheter or distended bladder)</span></div>" +
"<div style='position:absolute;left:132.74px;top:666.50px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    DO NOT use dipstick test in diagnosis of UTI in older people</span></div>" +
"<div style='position:absolute;left:132.74px;top:678.62px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    Obtain a MSU/ sterile urine sample via access port on catheter for urine</span></div>" +
"<div style='position:absolute;left:150.74px;top:690.02px' class='cls_010'><span class='cls_010'>culture and send to Microbiology</span></div>" +
"<div style='position:absolute;left:132.74px;top:702.26px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    If patient incontinent use an appropriate system to collect a sample (such</span></div>" +
"<div style='position:absolute;left:150.74px;top:713.78px' class='cls_010'><span class='cls_010'>as Newcastle urine collector)</span></div>" +
"<div style='position:absolute;left:132.74px;top:726.02px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    Start antibiotic therapy following local policy or as advised by Microbiology</span></div>" +
"<div style='position:absolute;left:132.74px;top:738.14px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    If patient has a urinary catheter, remove and replace it. Consider  the</span></div>" +
"<div style='position:absolute;left:150.74px;top:749.54px' class='cls_010'><span class='cls_010'>ongoing need for a long term catheter in consultation with specialists</span></div>" +
"<div style='position:absolute;left:132.74px;top:761.78px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    Consider use of analgesia (paracetamol or ibuprofen) to relieve pain</span></div>" +
"<div style='position:absolute;left:506.86px;top:766.70px' class='cls_012'><span class='cls_012'>Adopted and</span></div>" +
"<div style='position:absolute;left:132.74px;top:774.02px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    Consider admission to hospital if patient has fever with chills or new onset</span></div>" +
"<div style='position:absolute;left:506.86px;top:775.82px' class='cls_012'><span class='cls_012'>Reproduced from</span></div>" +
"<div style='position:absolute;left:150.74px;top:785.42px' class='cls_010'><span class='cls_010'>hypotension (low blood pressure)</span></div>" +
"<div style='position:absolute;left:506.86px;top:785.06px' class='cls_012'><span class='cls_012'>SIGN88</span></div>" +
"<div style='position:absolute;left:132.74px;top:797.66px' class='cls_026'><span class='cls_026'></span><span class='cls_010'>    Review response to treatment daily and  if no improvement of symptoms or</span></div>" +
"<div style='position:absolute;left:150.74px;top:808.94px' class='cls_010'><span class='cls_010'>deterioration, consider admission to hospital or an increased level of care</span></div>" +
"</div>" +
"<div style='position:absolute;left:50%;margin-left:-297px;top:26527px;width:595px;height:841px;border-style:outset;overflow:hidden'>" +
"<div style='position:absolute;left:0px;top:0px'>" +
"<img src='ff44baa0-a4f1-11e6-89aa-002590d31986_id_ff44baa0-a4f1-11e6-89aa-002590d31986_files/background42.jpg' width=595 height=841></div>" +
"<div style='position:absolute;left:188.30px;top:373.77px' class='cls_002'><span class='cls_002'>THIS PAGE IS INTENTIONALLY BLANK</span></div>" +
"<div style='position:absolute;left:528.10px;top:777.02px' class='cls_002'><span class='cls_002'>42</span></div></div></body></html>";

            
                htmlSource.Html = st;
            browser.HeightRequest= 20000;
            browser.BackgroundColor = Color.Blue;
            browser.Source = htmlSource;
            Content =new ScrollView { Content = browser };
             
        }
    }
}







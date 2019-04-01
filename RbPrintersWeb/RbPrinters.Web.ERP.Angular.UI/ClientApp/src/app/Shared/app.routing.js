"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var app_layout_component_1 = require("../_layout/app-layout/app-layout.component");
var dashboard_component_1 = require("../Dashboard/dashboard.component");
var login_component_1 = require("../Login/login.component");
//Services
var WeddingCard_OrderForm_Component_1 = require("../Services/WeddingCard/WeddingCard.OrderForm.Component");
var appRoutes = [
    //Site routes goes here 
    //{ 
    //    path: '', 
    //    component: SiteLayoutComponent,
    //    children: [
    //      { path: '', component: HomeComponent, pathMatch: 'full'},
    //      { path: 'about', component: AboutComponent },
    //      { path: 'test/:id', component: AboutComponent }
    //    ]
    //},
    // App routes goes here here
    {
        path: '',
        component: app_layout_component_1.AppLayoutComponent,
        children: [
            { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
            { path: 'dashboard', component: dashboard_component_1.DashboardComponent },
            { path: 'services/wedding-cards/AddOrder', component: WeddingCard_OrderForm_Component_1.WeddingCardOrderForm },
        ]
    },
    //no layout routes
    { path: 'login', component: login_component_1.LoginComponent },
    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];
exports.Routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map
import { Routes, RouterModule } from '@angular/router';
import { ProfileComponent } from './_components/profile/profile.component';
import { AppLayoutComponent } from './_layout';
import { HomeComponent } from './home/home.component';

const appRoutes: Routes = [
    //Site routes goes here
    {
        path: '',
        component: AppLayoutComponent,
        //canActivate: [AuthGuard],
        children: [
            { path: 'home', component: HomeComponent },
            { path: 'profile', component: ProfileComponent }
        ]
    },

    // no layout routes
    //{ path: '', component: LoadingComponent },
    //{ path: 'home', component: HomeComponent }
];

export const appRouting = RouterModule.forRoot(appRoutes);

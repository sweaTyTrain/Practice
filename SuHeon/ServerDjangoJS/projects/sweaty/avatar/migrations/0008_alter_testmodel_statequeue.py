# Generated by Django 5.0.3 on 2024-03-19 06:31

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('avatar', '0007_alter_testmodel_statequeue'),
    ]

    operations = [
        migrations.AlterField(
            model_name='testmodel',
            name='stateQueue',
            field=models.CharField(default='-1,-1,-1,-1,-1', max_length=50),
        ),
    ]

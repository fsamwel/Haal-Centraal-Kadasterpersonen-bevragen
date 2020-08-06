# coding: utf-8

"""
    Kadaster - BRK-Kadasterpersonen-Bevragen API

    D.m.v. deze toepassing worden meerdere, korte bevragingen op de Basis Registratie Kadaster beschikbaar gesteld. Deze toepassing betreft het verstrekken van informatie over bij het Kadaster geregistreerde natuurlijk personen en niet-natuurlijk personen.  # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class DatumOnvolledig(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'dag': 'int',
        'datum': 'date',
        'jaar': 'int',
        'maand': 'int'
    }

    attribute_map = {
        'dag': 'dag',
        'datum': 'datum',
        'jaar': 'jaar',
        'maand': 'maand'
    }

    def __init__(self, dag=None, datum=None, jaar=None, maand=None, local_vars_configuration=None):  # noqa: E501
        """DatumOnvolledig - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._dag = None
        self._datum = None
        self._jaar = None
        self._maand = None
        self.discriminator = None

        if dag is not None:
            self.dag = dag
        if datum is not None:
            self.datum = datum
        if jaar is not None:
            self.jaar = jaar
        if maand is not None:
            self.maand = maand

    @property
    def dag(self):
        """Gets the dag of this DatumOnvolledig.  # noqa: E501

        De dag. Als de dag van de datum bekend is wordt deze hier ingevuld. Ook als de volledige datum bekend is.  # noqa: E501

        :return: The dag of this DatumOnvolledig.  # noqa: E501
        :rtype: int
        """
        return self._dag

    @dag.setter
    def dag(self, dag):
        """Sets the dag of this DatumOnvolledig.

        De dag. Als de dag van de datum bekend is wordt deze hier ingevuld. Ook als de volledige datum bekend is.  # noqa: E501

        :param dag: The dag of this DatumOnvolledig.  # noqa: E501
        :type: int
        """
        if (self.local_vars_configuration.client_side_validation and
                dag is not None and dag > 31):  # noqa: E501
            raise ValueError("Invalid value for `dag`, must be a value less than or equal to `31`")  # noqa: E501
        if (self.local_vars_configuration.client_side_validation and
                dag is not None and dag < 1):  # noqa: E501
            raise ValueError("Invalid value for `dag`, must be a value greater than or equal to `1`")  # noqa: E501

        self._dag = dag

    @property
    def datum(self):
        """Gets the datum of this DatumOnvolledig.  # noqa: E501

        De volledige datum die in de `date` definitie past. Dit element wordt alleen gevuld als de volledige datum bekend is.  # noqa: E501

        :return: The datum of this DatumOnvolledig.  # noqa: E501
        :rtype: date
        """
        return self._datum

    @datum.setter
    def datum(self, datum):
        """Sets the datum of this DatumOnvolledig.

        De volledige datum die in de `date` definitie past. Dit element wordt alleen gevuld als de volledige datum bekend is.  # noqa: E501

        :param datum: The datum of this DatumOnvolledig.  # noqa: E501
        :type: date
        """

        self._datum = datum

    @property
    def jaar(self):
        """Gets the jaar of this DatumOnvolledig.  # noqa: E501

        Het jaar van de datum. Als het jaar bekend is wordt dit element gevuld, ook als de volledige datum bekend is.  # noqa: E501

        :return: The jaar of this DatumOnvolledig.  # noqa: E501
        :rtype: int
        """
        return self._jaar

    @jaar.setter
    def jaar(self, jaar):
        """Sets the jaar of this DatumOnvolledig.

        Het jaar van de datum. Als het jaar bekend is wordt dit element gevuld, ook als de volledige datum bekend is.  # noqa: E501

        :param jaar: The jaar of this DatumOnvolledig.  # noqa: E501
        :type: int
        """
        if (self.local_vars_configuration.client_side_validation and
                jaar is not None and jaar > 9999):  # noqa: E501
            raise ValueError("Invalid value for `jaar`, must be a value less than or equal to `9999`")  # noqa: E501

        self._jaar = jaar

    @property
    def maand(self):
        """Gets the maand of this DatumOnvolledig.  # noqa: E501

        De maand. Als de maand van een datum bekend is wordt deze hier ingevuld. Ook als de volledige datum is ingevuld.  # noqa: E501

        :return: The maand of this DatumOnvolledig.  # noqa: E501
        :rtype: int
        """
        return self._maand

    @maand.setter
    def maand(self, maand):
        """Sets the maand of this DatumOnvolledig.

        De maand. Als de maand van een datum bekend is wordt deze hier ingevuld. Ook als de volledige datum is ingevuld.  # noqa: E501

        :param maand: The maand of this DatumOnvolledig.  # noqa: E501
        :type: int
        """
        if (self.local_vars_configuration.client_side_validation and
                maand is not None and maand > 12):  # noqa: E501
            raise ValueError("Invalid value for `maand`, must be a value less than or equal to `12`")  # noqa: E501
        if (self.local_vars_configuration.client_side_validation and
                maand is not None and maand < 1):  # noqa: E501
            raise ValueError("Invalid value for `maand`, must be a value greater than or equal to `1`")  # noqa: E501

        self._maand = maand

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, DatumOnvolledig):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, DatumOnvolledig):
            return True

        return self.to_dict() != other.to_dict()
